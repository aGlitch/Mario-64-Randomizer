using Mario64Randomizer.SM64;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario64Randomizer.patches
{
    class Patch
    {
        static string ChksumPath = AppDomain.CurrentDomain.BaseDirectory + "patches\\chksum64.exe";

        public readonly string dirPath;

        public Patch(string dirPath)
        {
            this.dirPath = dirPath;
        }

        public void Apply(ROM rom)
        {
            string[] files = Directory.GetFiles(dirPath);
            foreach (string patchFile in files)
            {
                string patchName = Path.GetFileName(patchFile);
                if (int.TryParse(patchName, System.Globalization.NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int offset))
                {
                    byte[] data = File.ReadAllBytes(patchFile);
                    rom.WriteData(offset, data);
                }
            }
        }

        public static void FixChksum(string path)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = ChksumPath,
                Arguments = "\"" + path + "\"",
                UseShellExecute = false,
                CreateNoWindow = true,
            };
            Process.Start(startInfo);
        }
    }
}
