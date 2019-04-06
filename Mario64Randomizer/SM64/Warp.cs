using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario64Randomizer.SM64
{
    public class WarpFrom
    {
        public readonly byte id;

        public WarpFrom(ROM rom)
        {
            id = rom.Read8(2);
        }

        public void Write(ROM rom)
        {
            rom.Write8(id, 2);
        }
    }

    public class WarpTo
    {
        public readonly byte course;
        public readonly byte area;
        public readonly byte id;

        public WarpTo(ROM rom)
        {
            course = rom.Read8(3);
            area = rom.Read8(  4);
            id = rom.Read8(    5);
        }

        public void Write(ROM rom)
        {
            rom.Write8(course, 3);
            rom.Write8(area,   4);
            rom.Write8(id,     5);
        }
    }

    public class Warp
    {
        public readonly byte area;
        public readonly int course;
        public readonly WarpFrom from;
        public readonly WarpTo to;
        public readonly int addr;

        public Warp(byte area, int level, ROM rom, int addr)
        {
            this.area = area;
            this.course = level;
            rom.PushOffset(addr);
            this.from = new WarpFrom(rom);
            this.to   = new WarpTo  (rom);
            rom.PopOffset();
            this.addr = addr;
        }

        public Warp(byte area, int level, WarpFrom from, WarpTo to, int addr)
        {
            this.area = area;
            this.course = level;
            this.from = from;
            this.to   = to;
            this.addr = addr;
        }

        public void Write(ROM rom)
        {
            rom.PushOffset(addr);
            from.Write(rom);
            to.Write(rom);
            rom.PopOffset();
        }
    }
}
