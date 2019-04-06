using Mario64Randomizer.Helpers;
using Mario64Randomizer.SM64;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mario64Randomizer.Parsers
{
    class LevelScript
    {
        protected const int scrollBehaviour = 0x00402300;
        protected const int scrollBehaviourLegacy = 0x13003420;
        protected const int f2ScrollBehaviour= 0x0040F000;
        
        protected const int size = 0x40;
        protected const byte terminateCmd = 0x2;

        protected delegate void Parser<T>(ROM rom, T s);

        static protected void PerformLevelScriptParse<State>(ROM rom, int offset, Parser<State>[] parser, State state)
        {
            rom.PushOffset(offset);

            byte curCmdIndex;
            do
            {
                curCmdIndex = rom.Read8();
                byte curCmdSize = rom.Read8(1);

                if (curCmdSize == 0)
                    throw new ArgumentException("cmd size is 0, loop detected");

                Parser<State> func = parser[curCmdIndex];
                func(rom, state);

                if (curCmdIndex != 0x7)
                    rom.AddOffset(curCmdSize);
            }
            while (curCmdIndex != terminateCmd);

            rom.PopOffset();
        }

        protected static void Cmd00<T>(ROM rom, T state)
        {
            int segment = rom.Read8(3);
            //if (segment != 0x19)
            //    throw new ArgumentException("ROM does not use bank 0x19. Did you import a level?");

            int startAddress = rom.Read32(4);
            int endAddress = rom.Read32(8);
            SegmentDescriptor descriptor = new SegmentDescriptor(startAddress, endAddress - startAddress);
            rom.SetSegment(segment, descriptor);

            int segmentedAddress = rom.Read32(12);
            int levelscriptAddress = rom.GetROMAddress(segmentedAddress);
            rom.offset = levelscriptAddress - 0x10; // kostul for adding 0x10
        }

        protected static void Cmd06<T>(ROM rom, T state)
        {
            int segmentedAddress = rom.Read32(4);
            int segment = SegmentedAddressHelper.GetSegment(segmentedAddress);

            // 06 command will return one way or another, so just wait for it
            if (segment != 0x19 && segment != 0x0E)
                return;

            int romAddr = rom.GetROMAddress(segmentedAddress);
            rom.PushOffset(romAddr - 0x8); // -8 to trick the adding after cmd
        }

        protected static void Cmd07<T>(ROM rom, T state)
        {
            rom.PopOffset();
            rom.AddOffset(8); // diff between 0x07 length and 0x06 length
        }


        protected static void Cmd17<T>(ROM rom, T state)
        {
            int segment = rom.Read8(3);
            int startAddress = rom.Read32(4);
            int endAddress = rom.Read32(8);

            if ((uint)startAddress > 0x4000000)
                return;

            SegmentDescriptor descriptor = new SegmentDescriptor(startAddress, endAddress - startAddress);

            rom.SetSegment(segment, descriptor);
        }
    }
}
