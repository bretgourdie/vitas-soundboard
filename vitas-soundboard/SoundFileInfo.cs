using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace vitas_soundboard
{
    public class SoundFileInfo
    {
        private DirectoryInfo directory;
        private string wavExtension = ".wav";

        public SoundFileInfo(string path)
        {
            directory = new DirectoryInfo(path);

            if (!directory.Exists)
            {
                Console.WriteLine("SoundFileInfo: Directory \"" + path + "\" does not exist!");
            }
        }

        public FileInfo[] GetFiles()
        {
            return directory.GetFiles("*" + wavExtension);
        }
    }
}
