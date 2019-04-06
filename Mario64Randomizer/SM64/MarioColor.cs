using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario64Randomizer.SM64
{
    public class MarioColor
    {
        private const int bank4RAMStart = 0x7EC20;
        private const int bank4ROMStartPtr = 0x2ABCA4;

        public readonly int addr;
        public Color color;

        // If gs code looks like this
        //8107EC40 RRBB
        //8107EC42 GG00
        // passed address should be 7EC40
        public MarioColor(ROM rom, int ramAddr)
        {
            int bank4ROMStart = rom.Read32(bank4ROMStartPtr);
            this.addr = ramAddr - bank4RAMStart + bank4ROMStart;

            rom.PushOffset(addr);
            color = Color.FromArgb(0x00, rom.Read8(0), rom.Read8(2), rom.Read8(1));
            rom.PopOffset();
        }

        public MarioColor(ROM rom, int ramAddr, Color color)
        {
            rom.PushOffset(0);
            int bank4ROMStart = rom.Read32(bank4ROMStartPtr);
            rom.PopOffset();
            this.addr = ramAddr - bank4RAMStart + bank4ROMStart;
            rom.PushOffset(addr);
            this.color = Color.FromArgb(0, color.R, color.B, color.G); ;
            rom.PopOffset();
        }

        public void Write(ROM rom)
        {
            rom.PushOffset(addr);
            rom.Write8(color.R, 0);
            rom.Write8(color.B, 1);
            rom.Write8(color.G, 2);
            rom.Write8(color.A, 3);
            rom.PopOffset();
        }
    }
}