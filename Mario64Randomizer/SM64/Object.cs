using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario64Randomizer.SM64
{
    public class ObjectPosition
    {
        public readonly short X;
        public readonly short Y;
        public readonly short Z;


        public ObjectPosition(ROM rom)
        {
            X = rom.Read16(4);
            Y = rom.Read16(6);
            Z = rom.Read16(8);
        }
    
        public void Write(ROM rom)
        {
            rom.Write16(X, 4);
            rom.Write16(Y, 6);
            rom.Write16(Z, 8);
        }
    }

    public class ObjectRotation
    {
        public readonly short Rx;
        public readonly short Ry;
        public readonly short Rz;


        public ObjectRotation(ROM rom)
        {
            Rx = rom.Read16(10);
            Ry = rom.Read16(12);
            Rz = rom.Read16(14);
        }

        public void Write(ROM rom)
        {
            rom.Write16(Rx, 10);
            rom.Write16(Ry, 12);
            rom.Write16(Rz, 14);
        }
    }

    public enum ObjectStatus
    {
        Unknown,
        Grounded,
        NonGrounded
    }

    public class Object
    {
        public readonly byte area;
        public readonly byte act;
        public readonly byte model;
        public readonly int bparams;
        public readonly int behaviour;
        public readonly ObjectPosition position;
        public readonly ObjectRotation rotation;
        public readonly int addr;
        public readonly int level;

        static List<int> groundedBehaviours = Properties.Resources.groundedBehaviours
            .Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => Convert.ToInt32(x.Split(new char[] { ':' })[0].Trim(), 16)).ToList();

        static List<int> nonGroundedBehaviours = Properties.Resources.notGrounded
            .Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => Convert.ToInt32(x.Split(new char[] { ':' })[0].Trim(), 16)).ToList();

        public static void SetNonGroundedBehaviours(List<string> behaviours)
        {
            nonGroundedBehaviours = behaviours.Select(x => Convert.ToInt32(x.Split(new char[] { ':' })[0].Trim(), 16)).ToList();
        }

public byte BParam1 { get { return (byte)((bparams & 0xFF000000) >> 24); } }
        public byte BParam2 { get { return (byte)((bparams & 0x00FF0000) >> 16); } }

        public ObjectStatus status
        {
            get
            {
                if (groundedBehaviours.Contains(behaviour))
                    return ObjectStatus.Grounded;

                if (nonGroundedBehaviours.Contains(behaviour))
                    return ObjectStatus.NonGrounded;

                if (behaviour == 0x130008EC)
                {
                    if (BParam2 >= 16) // flying coins behaviour
                        return ObjectStatus.NonGrounded;
                    else // other coins behaviours that are put to ground
                        return ObjectStatus.Grounded;
                }

                return ObjectStatus.Unknown;
            }
        }

        public Object(byte area, int level, ROM rom, int addr)
        {
            this.area = area;
            this.level = level;

            rom.PushOffset(addr);

            position  = new ObjectPosition(rom);
            rotation  = new ObjectRotation(rom);
            act       = rom.Read8(2);
            model     = rom.Read8(3);
            bparams   = rom.Read32(16);
            behaviour = rom.Read32(20);
            this.addr = addr;

            rom.PopOffset();
        }

        public Object(byte area, int level, byte act, byte model, int bparams, int behaviour, ObjectPosition position, ObjectRotation rotation, int addr)
        {
            this.area = area;
            this.level = level;
            this.behaviour = behaviour;
            this.addr = addr;
            this.position = position;
            this.rotation = rotation;
            this.act = act;
            this.model = model;
            this.bparams = bparams;
        }

        public void Write(ROM rom)
        {
            rom.PushOffset(addr);

            position.Write(rom);
            rotation.Write(rom);
            rom.Write8(act, 2);
            rom.Write8(model, 3);
            rom.Write32(bparams, 16);
            rom.Write32(behaviour, 20);

            rom.PopOffset();
        }
    }
}
