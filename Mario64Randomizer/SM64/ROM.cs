using Mario64Randomizer.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Mario64Randomizer.SM64
{
    public class SegmentDescriptor
    {
        public int start;
        public int length;

        public SegmentDescriptor(int start, int length)
        {
            this.start = start;
            this.length = length;
        }
    }

    public class ROM
    {
        public byte[] rom;
        SegmentDescriptor[] segments;
        public int offset;
        public Stack<int> offsetStack;
        public int levelScriptEntryOffset;

        public ROM(byte[] rom)
        {
            this.rom = rom;
            segments = new SegmentDescriptor[0x20];
            for (int i = 0; i < 0x20; i++)
                segments[i] = null;

            offsetStack = new Stack<int>();
        }

        public void AddOffset(int delta)
        {
            this.offset += delta;
        }

        public void Write8(byte data, int extraOffset = 0)
        {
            rom[offset + extraOffset] = data;
        }

        public byte Read8(int extraOffset = 0)
        {
            return rom[offset + extraOffset];
        }

        public Int16 Read16(int extraOffset = 0)
        {
            Int16 ret = BitConverter.ToInt16(rom, offset + extraOffset);
            return (Int16) IPAddress.NetworkToHostOrder(ret);
        }

        public void Write16(int data, int extraOffset = 0)
        {
            int endianData = IPAddress.HostToNetworkOrder(data);
            byte[] convertedData = BitConverter.GetBytes(endianData);
            Array.Copy(convertedData, 2, rom, offset + extraOffset, 2);
        }

        public Int32 Read32(int extraOffset = 0)
        {
            Int32 ret = BitConverter.ToInt32(rom, offset + extraOffset);
            return (Int32) IPAddress.NetworkToHostOrder(ret);
        }

        public void Write32(int data, int extraOffset = 0)
        {
            int endianData = IPAddress.HostToNetworkOrder(data);
            byte[] convertedData = BitConverter.GetBytes(endianData);
            Array.Copy(convertedData, 0, rom, offset + extraOffset, 4);
        }

        public Int64 Read64(int extraOffset = 0)
        {
            Int64 ret = BitConverter.ToInt64(rom, offset + extraOffset);
            return IPAddress.NetworkToHostOrder(ret);
        }
        public void Write64(UInt64 data, int extraOffset = 0)
        {
            Int64 endianData = IPAddress.HostToNetworkOrder((Int64)data);
            byte[] convertedData = BitConverter.GetBytes(endianData);
            Array.Copy(convertedData, 0, rom, offset + extraOffset, 8);
        }

        public byte PRead8(int offset)
        {
            return rom[offset];
        }

        public Int16 PRead16(int offset)
        {
            Int16 ret = BitConverter.ToInt16(rom, offset);
            return IPAddress.NetworkToHostOrder(ret);
        }

        public Int32 PRead32(int offset)
        {
            Int32 ret = BitConverter.ToInt32(rom, offset);
            return IPAddress.NetworkToHostOrder(ret);
        }

        public Int64 PRead64(int offset)
        {
            Int64 ret = BitConverter.ToInt64(rom, offset);
            return IPAddress.NetworkToHostOrder(ret);
        }

        public void SetSegment(int segment, SegmentDescriptor descriptor)
        {
            if (segment > 0x20)
                return;

            segments[segment] = descriptor;
        }

        public int GetROMAddress(int segmentedAddress)
        {
            int segment = SegmentedAddressHelper.GetSegment(segmentedAddress);
            int offset  = SegmentedAddressHelper.GetOffset(segmentedAddress); 

            if (segment > 0x20)
                return -1;

            if (segments[segment] == null)
                return -1;

            return segments[segment].start + offset;
        }

        public int GetSegmentedAddress(int romAddress)
        {
            for (int currentSegment = 0; currentSegment < 0x20; currentSegment++)
            {
                SegmentDescriptor descriptor = segments[currentSegment];
                if (descriptor == null)
                    continue;

                if (descriptor.start <= romAddress && romAddress <= descriptor.start + descriptor.length)
                    return SegmentedAddressHelper.GetSegmentedAddress(currentSegment, romAddress - descriptor.start);
            }

            return -1;
        }

        public void PushOffset(int newOffset)
        {
            offsetStack.Push(offset);
            offset = newOffset;
        }

        public void PopOffset()
        {
            offset = offsetStack.Pop();
        }

        public void ReadData(int offset, byte[] source)
        {
            Array.Copy(rom, offset, source, 0, source.Length);
        }

        public void WriteData(int offset, byte[] source)
        {
            Array.Copy(source, 0, rom, offset, source.Length);
        }

        public SegmentDescriptor GetSegmentDescriptor(int segment)
        {
            if (segment >= 0x20)
                return null;

            return segments[segment];
        }
    }
}
