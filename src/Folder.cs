using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PlotChecker.src
{
    [Serializable]
    public class Folder
    {
        public Dictionary<string, Plot> plotList = new Dictionary<string, Plot>();

        public string folderName;
        public string fullPath;

        public Folder(string path) {
            var handle = new DirectoryInfo(path);
            this.folderName = handle.Name;
            this.fullPath = handle.FullName;
            this.scanForPlots();
        }

        public Folder()
        {
        }

        public void scanForPlots() {

            foreach (FileInfo item in new DirectoryInfo(this.fullPath).GetFiles("*.plot"))
            {
                this.plotList.Add(Tools.GetMD5HashFromString(item.Name), new Plot(new FileInfo(item.FullName)));
            }

        }

    }
}
