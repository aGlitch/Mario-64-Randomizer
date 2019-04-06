using Mario64Randomizer.SM64;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Mario64Randomizer.Parsers
{
    class FindObjectsParser : LevelScript
    {    
        protected class ParseState
        {
            public readonly List<SM64.Object> objects;
            public byte areaId;
            public readonly int level;

            public ParseState(int level)
            {
                this.level = level;

                objects = new List<SM64.Object>();
                areaId = 0;
            }
        }

        public static List<SM64.Object> FindObjects(ROM rom, int offset, int level)
        {
            ParseState state = new ParseState(level);
            PerformLevelScriptParse(rom, offset, findObjectsParser, state);
            return state.objects;
        }

        static readonly Parser<ParseState>[] findObjectsParser = new Parser<ParseState>[LevelScript.size];

        static FindObjectsParser()
        {
            Type t = typeof(FindObjectsParser);
            for (int i = 0; i < size; i++)
            {
                findObjectsParser[i] = Common;
                string name = "Cmd" + string.Format("{0:X2}", i);
                MethodInfo info = t.GetMethod(name, BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.FlattenHierarchy);
                if (info == null)
                    continue;

                // LevelScript definitions are generic
                if (info.IsGenericMethod)
                    info = info.MakeGenericMethod(typeof(ParseState));

                if (Delegate.CreateDelegate(typeof(Parser<ParseState>), info) is Parser<ParseState> cmd)
                    findObjectsParser[i] = cmd;
            }
        }

        private static void Common(ROM rom, ParseState state) { }

        protected static void Cmd1F(ROM rom, ParseState state)
        {
            state.areaId = rom.Read8(2);
        }

        protected static void Cmd24(ROM rom, ParseState state)
        {
            SM64.Object curObject = new SM64.Object(state.areaId, state.level, rom, rom.offset);
            state.objects.Add(curObject);
        }
    }
}
