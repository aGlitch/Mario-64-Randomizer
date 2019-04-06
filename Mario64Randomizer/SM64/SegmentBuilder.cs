using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelCombiner
{
    class DataBuilder
    {
        // Offset is aligned on 0x10
        int start;
        int offset;
        byte[] data;

        int backedUpOffset;

        public int Offset { get => offset; set => offset = value; }
        public byte[] Data { get => data; }

        public DataBuilder(int start, int length)
        {
            data = new byte[length];
            this.start = start;
            offset = 0;
        }

        public void RoundOffset()
        {
            double notRoundOffset = offset;
            offset = ((int) Math.Ceiling(notRoundOffset / 0x10) * 0x10);
        }

        public void Backup()
        {
            backedUpOffset = offset;
        }

        public void Restore()
        {
            offset = backedUpOffset;
        }
    }
}
