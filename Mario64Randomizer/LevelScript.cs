using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelCombiner
{
    class LevelScript
    {
        const int scrollBehaviour = 0x00402300;
        const int scrollBehaviourLegacy = 0x13003420;
        const int f2ScrollBehaviour= 0x0040F000;

        delegate void RegionParseCmd(ROM rom, List<Region> regions, RegionParseState state);
        delegate void RelocationParseCmd(ROM rom, RelocationTable table, RegionParseState state);

        const int size = 0x40;
        static RegionParseCmd[]     regionParser     = new RegionParseCmd[size];
        static RelocationParseCmd[] relocationParser = new RelocationParseCmd[size];

        static LevelScript()
        {
            // Use reflections to detect declared parse methods
            Type t = typeof(LevelScript);
            for (int i = 0; i < size; i++)
            {
                regionParser[i] = RegionParse_common;

                string name = "RegionParse_cmd" + string.Format("{0:X2}", i);
                MethodInfo info = t.GetMethod(name, BindingFlags.NonPublic | BindingFlags.Static);
                if (info == null)
                    continue;

                RegionParseCmd cmd = Delegate.CreateDelegate(typeof(RegionParseCmd), info) as RegionParseCmd;
                if (cmd == null)
                    continue;

                regionParser[i] = cmd;
            }

            for (int i = 0; i < size; i++)
            {
                relocationParser[i] = RelocationParse_common;

                string name = "RelocationParse_cmd" + string.Format("{0:X2}", i);
                MethodInfo info = t.GetMethod(name, BindingFlags.NonPublic | BindingFlags.Static);
                if (info == null)
                    continue;

                RelocationParseCmd cmd = Delegate.CreateDelegate(typeof(RelocationParseCmd), info) as RelocationParseCmd;
                if (cmd == null)
                    continue;

                relocationParser[i] = cmd;
            }
        }

        class RegionParseState
        {
            public int start;
            public RegionState regionState;
            public Stack<int> retAddressStack;
            public sbyte area;
            public bool isOldBehaviourChecked;

            public RegionParseState()
            {
                regionState = RegionState.LevelHeader;
                retAddressStack = new Stack<int>();
            }
        }

        const byte terminateCmd = 0x2;

        public static void PerformRegionParse(ROM rom, List<Region> regions, int offset, bool isOldScrollBehaviour)
        {
            rom.PushOffset(offset);

            RegionParseState state = new RegionParseState
            {
                start = rom.offset,
                isOldBehaviourChecked = isOldScrollBehaviour
            };

            byte curCmdIndex;
            do
            {
                curCmdIndex = rom.Read8();
                byte curCmdSize = rom.Read8(1);

                if (curCmdSize == 0)
                    throw new ArgumentException("cmd size is 0, loop detected");

                RegionParseCmd func = regionParser[curCmdIndex];
                if (func != RegionParse_common)
                    RegionParse_common(rom, regions, state);
                
                func(rom, regions, state);

                if (curCmdIndex != 0x7)
                    rom.AddOffset(curCmdSize);
            }
            while (curCmdIndex != terminateCmd);

            rom.PopOffset();
        }

        public static void PerformRegionRelocation(Region region, RelocationTable table, sbyte area = -1, bool isOldScrollBehaviour = false)
        {
            // This is fake rom but it works anyways, just more convenient
            ROM rom = new ROM(region.data);
            RegionParseState state = new RegionParseState
            {
                area = area,
                isOldBehaviourChecked = isOldScrollBehaviour
            };

            byte curCmdIndex;
            while (rom.offset < region.length)
            {
                curCmdIndex = rom.Read8();
                byte curCmdSize = rom.Read8(1);

                if (curCmdSize == 0)
                    throw new ArgumentException("cmd size is 0, loop detected");

                RelocationParseCmd func = relocationParser[curCmdIndex];
                func(rom, table, state);

                if (curCmdIndex != 0x7)
                    rom.AddOffset(curCmdSize);
            }
            
        }

        public static void PerformHeaderParse(ROM rom, int offset)
        {
            rom.PushOffset(offset);

            RegionParseState state = new RegionParseState();
            state.start = rom.offset;

            byte curCmdIndex;
            int stepCounter = 0;
            do
            {
                curCmdIndex = rom.Read8();
                byte curCmdSize = rom.Read8(1);

                if (curCmdSize == 0)
                    throw new ArgumentException("cmd size is 0, loop detected");

                if (curCmdIndex == 0x00)
                    HeaderParse_cmd00(rom);

                if (curCmdIndex == 0x17)
                    HeaderParse_cmd17(rom);

                rom.AddOffset(curCmdSize);
                stepCounter++;

                if (stepCounter > 100)
                    throw new ArgumentException("Bank 0x19 && 0x0E loader was not detected");
            }
            while (rom.GetSegmentDescriptor(0x0E) == null || rom.GetSegmentDescriptor(0x19) == null);

            rom.PopOffset();
        }

        public static void FixLoadAddresses(ROM initROM, Region region)
        {
            // This is fake rom but it works anyways, just more convenient
            ROM rom = new ROM(region.data);

            RegionParseState state = new RegionParseState();
            state.start = rom.offset;

            byte curCmdIndex;
            int stepCounter = 0;
            do
            {
                curCmdIndex = rom.Read8();
                byte curCmdSize = rom.Read8(1);

                if (curCmdSize == 0)
                    throw new ArgumentException("cmd size is 0, loop detected");

                if (curCmdIndex == 0x17)
                {
                    HeaderFix_cmd17(rom, initROM, out bool isFixed);
                    if (isFixed)
                        break;
                }

                rom.AddOffset(curCmdSize);
                stepCounter++;

                if (stepCounter > 100)
                    throw new ArgumentException("Bank 0x19 && 0x0E loader was not detected");
            }
            while (rom.GetSegmentDescriptor(0x0E) == null || rom.GetSegmentDescriptor(0x19) == null);
        }

        private static void CutRegion(ROM rom, List<Region> regions, RegionParseState state, int regionEnd, RegionState newState)
        {
            // Trim 0x1008000000000000 commands from beginning
            int regionStart = state.start;
            if (rom.PRead64(regionStart) == 0x1008000000000000)
                regionStart += 8;

            if (regionStart == regionEnd)
                return;

            Region region = new LevelScriptRegion(regionStart, regionEnd - regionStart, state.regionState);
            region.area = state.area;
            regions.Add(region);

            state.regionState = newState;
            state.start = regionEnd;
        }

        private static void RegionParse_common(ROM rom, List<Region> regions, RegionParseState state)
        {
            int curCmd = rom.Read8();
            if ((state.regionState == RegionState.AreaData || state.regionState == RegionState.AreaScrolls || state.regionState == RegionState.AreaF2Scrolls) && curCmd != 0x24 && curCmd != 0x26)
            {
                CutRegion(rom, regions, state, rom.offset, RegionState.AreaFooter);
            }
        }

        private static void RelocationParse_common(ROM rom, RelocationTable table, RegionParseState state) { }

        private static void HeaderParse_common(ROM rom) { }
 
        private static void RegionParse_cmd00(ROM rom, List<Region> regions, RegionParseState state)
        {
            int segment = rom.Read8(3);
            if (segment != 0x19)
                throw new MessageException("ROM does not use bank 0x19. Did you import a level?");

            int startAddress = rom.Read32(4);
            int endAddress   = rom.Read32(8);
            SegmentDescriptor descriptor = new SegmentDescriptor(startAddress, endAddress - startAddress);
            rom.SetSegment(segment, descriptor);

            int segmentedAddress = rom.Read32(12);
            int levelscriptAddress = rom.GetROMAddress(segmentedAddress);
            rom.offset = levelscriptAddress - 0x10; // kostul for adding 0x10
            state.start = levelscriptAddress;
        }
        private static void HeaderParse_cmd00(ROM rom)
        {
            int segment = rom.Read8(3);
            if (segment != 0x19)
                throw new MessageException("ROM does not use bank 0x19. Did you import a level?");

            int startAddress = rom.Read32(4);
            int endAddress = rom.Read32(8);
            SegmentDescriptor descriptor = new SegmentDescriptor(startAddress, endAddress - startAddress);
            rom.SetSegment(segment, descriptor);

            rom.levelScriptEntryOffset = rom.offset + 12;

            int segmentedAddress = rom.Read32(12);
            int levelscriptAddress = rom.GetROMAddress(segmentedAddress);
            rom.offset = levelscriptAddress - 0x10; // kostul for adding 0x10
        }

        private static void RegionParse_cmd02(ROM rom, List<Region> regions, RegionParseState state)
        {
            CutRegion(rom, regions, state, rom.offset + rom.Read8(1), RegionState.LevelHeader);
        }

        private static void RegionParse_cmd06(ROM rom, List<Region> regions, RegionParseState state)
        {
            int segmentedAddress = rom.Read32(4);
            int segment = SegmentedAddressHelper.GetSegment(segmentedAddress);

            // 06 command will return one way or another, so just wait for it
            if (segment != 0x19)
                return;

            CutRegion(rom, regions, state, rom.offset, state.regionState);

            state.retAddressStack.Push(rom.offset + rom.Read8(1));
            int offset = (int) rom.GetROMAddress(segmentedAddress);
            rom.offset = offset - 8; // kostul for next cmd switching
            state.start = offset;
        }

        private static void RegionParse_cmd07(ROM rom, List<Region> regions, RegionParseState state)
        {
            CutRegion(rom, regions, state, rom.offset, state.regionState);

            int retAddr = state.retAddressStack.Pop();
            rom.offset = retAddr;
            state.start = retAddr;
        }

        private static void RegionParse_cmd10(ROM rom, List<Region> regions, RegionParseState state)
        {
            if (rom.Read64() == 0x1008000000000000)
            {
                if (rom.offset == state.start)
                {
                    state.start = rom.offset + rom.Read8(1);
                }
                // Skip empty commands in the beginning of any region
                else if (rom.offset == state.start + rom.Read8(1))
                {
                    state.start = rom.offset + rom.Read8(1);
                }
                else
                {
                    // Commands is not in the beginning, cut area, start new one that is same as it was before
                    if (state.regionState == RegionState.ModelsLoader)
                        CutRegion(rom, regions, state, rom.offset, state.regionState);
                }
            }
        }

        private static void RegionParse_cmd17(ROM rom, List<Region> regions, RegionParseState state)
        {
            int segment = rom.Read8(3);
            int startAddress = rom.Read32(4);
            int endAddress   = rom.Read32(8);

            if ((uint)startAddress > 0x4000000)
                return;

            SegmentDescriptor descriptor = new SegmentDescriptor(startAddress, endAddress - startAddress);

            rom.SetSegment(segment, descriptor);
        }

        private static void HeaderParse_cmd17(ROM rom)
        {
            int segment = rom.Read8(3);
            int startAddress = rom.Read32(4);
            int endAddress = rom.Read32(8);

            SegmentDescriptor descriptor = new SegmentDescriptor(startAddress, endAddress - startAddress);

            rom.SetSegment(segment, descriptor);
        }

        private static void HeaderFix_cmd17(ROM rom, ROM initROM, out bool isFixed)
        {
            int segment = rom.Read8(3);
            int startAddress = initROM.GetSegmentDescriptor(0x0E).start;
            int endAddress = startAddress + initROM.GetSegmentDescriptor(0x0E).length;

            if (segment != 0x0E)
            {
                isFixed = false;
                return;
            }

            rom.Write32(startAddress, 4);
            rom.Write32(endAddress, 8);
            isFixed = true;
        }

        private static void RegionParse_cmd1E(ROM rom, List<Region> regions, RegionParseState state)
        {
            // it is end of level, area footer is saved
            state.regionState = RegionState.LevelFooter;
        }

        private static void RegionParse_cmd1F(ROM rom, List<Region> regions, RegionParseState state)
        {
            CutRegion(rom, regions, state, rom.offset, RegionState.AreaHeader);

            int segmentedAddress = rom.Read32(4);
            int segment = rom.Read8(4);
            sbyte area = (sbyte) rom.Read8(2);
            state.area = area;
            state.regionState = RegionState.AreaHeader;

            // Only 0x19 or 0x0E commands are supported
            // Usually it is in segment 19 anyways
            if (segment != 0x19 && segment != 0x0E)
                return;

            int geoLayoutROMAddress = rom.GetROMAddress(segmentedAddress);
            List<Region> areaGeolayoutRegions = new List<Region>();

            try
            {
                GeoLayout.PerformRegionParse(rom, areaGeolayoutRegions, geoLayoutROMAddress);
                foreach (Region region in areaGeolayoutRegions)
                    region.area = area;

                regions.AddRange(areaGeolayoutRegions);
            }
            catch (NotSupportedException e)
            {
                MessageBox.Show(String.Format("Area {0} graphics parsing is not supported! Reason : '{1}'", state.area, e.Message), "Level Parser", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format("Failed to parse area {0} graphics! Reason : '{1}'", state.area, e.Message), "Level Parser", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void RelocationParse_cmd1F(ROM rom, RelocationTable table, RegionParseState state)
        {
            rom.Write8((byte) state.area, 2);
            table.RelocateOffset((int) state.area, rom, 4);
        }

        private static void RegionParse_cmd20(ROM rom, List<Region> regions, RegionParseState state)
        {
            CutRegion(rom, regions, state, rom.offset + rom.Read8(1), RegionState.AreaHeader);
            state.area = -1;
        }

        private static void RegionParse_cmd21(ROM rom, List<Region> regions, RegionParseState state)
        {
            if (state.regionState != RegionState.ModelsLoader)
                CutRegion(rom, regions, state, rom.offset, RegionState.ModelsLoader);

            int segmentedAddress = rom.Read32(4);
            int segment = rom.Read8(4);
            int model = rom.Read8(3);

            // Only 0x19 or 0x0E commands are supported
            if (segment != 0x19 && segment != 0x0E)
                return;

            int displayListROMAddress = (int)rom.GetROMAddress(segmentedAddress);

            try
            {
                List<Region> modelRegions = new List<Region>();
                DisplayList.PerformRegionParse(rom, modelRegions, displayListROMAddress, rom.Read8(2));

                foreach (Region region in modelRegions)
                    region.model = model;

                regions.AddRange(modelRegions);
            }
            catch (NotSupportedException e)
            {
                MessageBox.Show(String.Format("Model {0} graphics parsing is not supported! Reason : '{1}'", model, e.Message), "Level Parser", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format("Failed to parse model {0} graphics! Reason : '{1}'", model, e.Message), "Level Parser", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void RelocationParse_cmd21(ROM rom, RelocationTable table, RegionParseState state)
        {
            int model = rom.Read8(3);
            table.RelocateOffset(model, rom, 4);
        }

        private static void RegionParse_cmd22(ROM rom, List<Region> regions, RegionParseState state)
        {
            if (state.regionState != RegionState.ModelsLoader)
                CutRegion(rom, regions, state, rom.offset, RegionState.ModelsLoader);

            int segmentedAddress = rom.Read32(4);
            int segment = rom.Read8(4);
            int model = rom.Read8(3);

            // Only 0x19 or 0x0E commands are supported
            if (segment != 0x19 && segment != 0x0E)
                return;

            try
            {
                List<Region> modelRegions = new List<Region>();

                int geoLayoutROMAddress = rom.GetROMAddress(segmentedAddress);
                GeoLayout.PerformRegionParse(rom, modelRegions, geoLayoutROMAddress);

                foreach (Region region in modelRegions)
                    region.model = model;

                regions.AddRange(modelRegions);
            }
            catch (NotSupportedException e)
            {
                MessageBox.Show(String.Format("Model {0} graphics parsing is not supported! Reason : '{1}'", state.area, e.Message), "Level Parser", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format("Failed to parse model {0} graphics! Reason : '{1}'", state.area, e.Message), "Level Parser", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void RelocationParse_cmd22(ROM rom, RelocationTable table, RegionParseState state)
        {
            int model = rom.Read8(3);
            table.RelocateOffset(model, rom, 4);
        }

        private static void RegionParse_cmd24(ROM rom, List<Region> regions, RegionParseState state)
        {
            int behaviour = rom.Read32(0x14);
            if (behaviour == scrollBehaviour || behaviour == scrollBehaviourLegacy)
            {
                if (state.regionState != RegionState.AreaScrolls)
                {
                    CutRegion(rom, regions, state, rom.offset, RegionState.AreaScrolls);
                }
            }
            else if (behaviour == f2ScrollBehaviour)
            {
                if (state.regionState != RegionState.AreaF2Scrolls)
                {
                    CutRegion(rom, regions, state, rom.offset, RegionState.AreaF2Scrolls);
                }
            }
            else
            {
                if (state.regionState != RegionState.AreaData)
                {
                    CutRegion(rom, regions, state, rom.offset, RegionState.AreaData);
                    return;
                }
            }
        }

        private static void RelocationParse_cmd24(ROM rom, RelocationTable table, RegionParseState state)
        {
            int behaviour = rom.Read32(0x14);
            if (behaviour == scrollBehaviour || behaviour == scrollBehaviourLegacy)
            {
                int address = 0;

                int intX = rom.Read16(0x04);
                float X = intX;
                byte[] Xdata = BitConverter.GetBytes(X);

                address += Xdata[2] * 0x10000;
                address += (ushort) rom.Read16(0x10);

                int segmentedAddress = address - 0x20000 + 0x0E000000;

                int newSegmentedAddress = table.Relocate((int) state.area, segmentedAddress);
                if (newSegmentedAddress == -1)
                    throw new ArgumentException("Failed to relocate scrolling texture!");

                int newAddress = newSegmentedAddress - 0x0E000000 + 0x20000;

                Xdata[2] = (byte) ((newAddress >> 16) & 0xFF);
                float newX = BitConverter.ToSingle(Xdata, 0);
                int newIntX = Convert.ToInt16(newX);

                rom.Write16(newIntX, 0x04);
                rom.Write16(newAddress & 0xFFFF, 0x10);
                rom.Write32(state.isOldBehaviourChecked ? scrollBehaviourLegacy : scrollBehaviour, 0x14);
            }
            if (behaviour == f2ScrollBehaviour)
            {
                int address = rom.Read32(0x10);
                int newAddress = table.Relocate((int) state.area, address);
                //rom.Write32(newAddress, 0x10);
            }
        }

        private static void RegionParse_cmd26(ROM rom, List<Region> regions, RegionParseState state)
        {
            if (state.regionState != RegionState.AreaData)
                CutRegion(rom, regions, state, rom.offset, RegionState.AreaData);
        }

        private static void RegionParse_cmd2E(ROM rom, List<Region> regions, RegionParseState state)
        {
            int segmentedAddress = rom.Read32(4);
            int segment = rom.Read8(4);

            // Only 0x19 or 0x0E commands are supported
            if (segment != 0x19 && segment != 0x0E)
                return;

            try
            {
                List<Region> collisionRegions = new List<Region>();
                Collision.PerformRegionParse(rom, collisionRegions, (int)rom.GetROMAddress(segmentedAddress));
                foreach (Region region in collisionRegions)
                    region.area = state.area;

                regions.AddRange(collisionRegions);
            }
            catch (NotSupportedException e)
            {
                MessageBox.Show(String.Format("Model {0} collision parsing is not supported! Reason : '{1}'", state.area, e.Message), "Level Parser", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format("Failed to parse model {0} collision! Reason : '{1}'", state.area, e.Message), "Level Parser", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void RelocationParse_cmd2E(ROM rom, RelocationTable table, RegionParseState state)
        {
            table.RelocateOffset((int) state.area, rom, 4);
        }
    }
}
