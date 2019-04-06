using Mario64Randomizer.SM64;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Mario64Randomizer.Parsers
{
    class FindSongsParser : LevelScript
    {
        protected class ParseState
        {
            public readonly List<Song> songs;

            public ParseState()
            {
                songs = new List<Song>();
            }
        }

        public static List<Song> FindSongs(ROM rom, int offset)
        {
            ParseState state = new ParseState();
            PerformLevelScriptParse<ParseState>(rom, offset, findSongsParser, state);
            return state.songs;
        }

        static readonly Parser<ParseState>[] findSongsParser = new Parser<ParseState>[LevelScript.size];

        static FindSongsParser()
        {
            Type t = typeof(FindSongsParser);
            for (int i = 0; i < size; i++)
            {
                findSongsParser[i] = Common;
                string name = "Cmd" + string.Format("{0:X2}", i);
                MethodInfo info = t.GetMethod(name, BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.FlattenHierarchy);
                if (info == null)
                    continue;

                // LevelScript definitions are generic
                if (info.IsGenericMethod)
                    info = info.MakeGenericMethod(typeof(ParseState));

                if (Delegate.CreateDelegate(typeof(Parser<ParseState>), info) is Parser<ParseState> cmd)
                    findSongsParser[i] = cmd;
            }
        }

        private static void Common(ROM rom, ParseState state) { }

        protected static void Cmd36(ROM rom, ParseState state) //static
        {
            Song song = new Song(rom, rom.offset, 0x05);
            state.songs.Add(song);
        }

        protected static void Cmd37(ROM rom, ParseState state) //static
        {
            Song song = new Song(rom, rom.offset, 0x03);
            state.songs.Add(song);
        }
    }
}
