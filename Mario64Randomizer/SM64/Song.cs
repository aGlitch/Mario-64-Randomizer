using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario64Randomizer.SM64
{
    public class Song
    {        
        public readonly int addr;
        public readonly byte seqNumber;
        public readonly int musicOffset;

        public Song(ROM rom, int addr, int offset)
        {
            rom.PushOffset(addr);
            this.seqNumber = rom.Read8(offset); // Read the Sequence number
            rom.PopOffset();
            this.addr = addr;
            this.musicOffset = offset; // 0x03 for menu music, 0x05 for course music
        }

        public Song(byte seqNumber, int addr, int offset)
        {
            this.seqNumber = seqNumber;
            this.addr = addr;
            this.musicOffset = offset;
        }

        public void Write(ROM rom)
        {
            Console.WriteLine("Writing: " + this.seqNumber.ToString("X") + " into: " + this.addr.ToString() + ", offset: " + this.musicOffset);
            rom.PushOffset(addr);
            rom.Write8(seqNumber, musicOffset);
            rom.PopOffset();            
        }
    }
}
