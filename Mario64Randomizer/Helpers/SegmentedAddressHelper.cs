using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario64Randomizer.Helpers
{
    class SegmentedAddressHelper
    {
        const int staticRelocationAddress = 0x00800000;
        const int staticRelocationAddress0E = 0x0E000000 | staticRelocationAddress;
        const int staticRelocationAddress19 = 0x19000000 | staticRelocationAddress;

        public static int GetSegment(int segmentedAddress)
        {
            return (int) ((segmentedAddress & 0xFF000000) >> 24);
        }

        public static int GetOffset(int segmentedAddress)
        {
            return segmentedAddress & 0x00FFFFFF;
        }

        public static int GetSegmentedAddress(int segment, int offset)
        {
            return (segment << 24) | offset; 
        }

        public static int GetStaticSegmentedAddress(int segment)
        {
            return GetSegmentedAddress(segment, staticRelocationAddress);
        }
    }
}
