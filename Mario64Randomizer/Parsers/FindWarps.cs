using Mario64Randomizer.SM64;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Mario64Randomizer.Parsers
{
    class FindWarpsParser : LevelScript
    {
        protected class ParseState
        {
            public readonly List<Warp> warps;
            public byte areaId;
            public readonly int level;

            public ParseState(int level)
            {
                this.level = level;
                warps = new List<Warp>();
                areaId = 0xFF;
            }
        }

        public static List<Warp> FindWarps(ROM rom, int offset, int level)
        {
            ParseState state = new ParseState(level);
            PerformLevelScriptParse<ParseState>(rom, offset, findWarpsParser, state);
            return state.warps;
        }

        static readonly Parser<ParseState>[] findWarpsParser = new Parser<ParseState>[LevelScript.size];

        static FindWarpsParser()
        {
            Type t = typeof(FindWarpsParser);
            for (int i = 0; i < size; i++)
            {
                findWarpsParser[i] = Common;
                string name = "Cmd" + string.Format("{0:X2}", i);
                MethodInfo info = t.GetMethod(name, BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.FlattenHierarchy);
                if (info == null)
                    continue;

                // LevelScript definitions are generic
                if (info.IsGenericMethod)
                    info = info.MakeGenericMethod(typeof(ParseState));

                if (Delegate.CreateDelegate(typeof(Parser<ParseState>), info) is Parser<ParseState> cmd)
                    findWarpsParser[i] = cmd;
            }
        }

        private static void Common(ROM rom, ParseState state) { }

        protected static void Cmd1F(ROM rom, ParseState state)
        {
            state.areaId = rom.Read8(2);
        }

        protected static void Cmd26(ROM rom, ParseState state)
        {
            Warp warp = new Warp(state.areaId, state.level, rom, rom.offset);
            state.warps.Add(warp);
        }

        protected static void Cmd27(ROM rom, ParseState state)
        {
            Warp warp = new Warp(0xFF, state.level, rom, rom.offset);
            state.warps.Add(warp);
        }
    }
}
