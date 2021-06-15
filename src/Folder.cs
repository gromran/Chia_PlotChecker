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
    public class Folder
    {
        public HashSet<Plot> plotList = new HashSet<Plot>();

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
                this.plotList.Add(new Plot(new FileInfo(item.FullName)));
            }

        }

        public string SerializeToJSON()
        {
            Dictionary<string,string> res = new Dictionary<string, string>();
            res.Add("folderName", this.folderName);
            res.Add("fullPath", this.fullPath);

            List<string> plots = new List<string>();

            foreach (var item in plotList)
            {
                plots.Add(item.SerializeToJSON());
            }

            res.Add("plots", JsonSerializer.Serialize(plots));



            var s = JsonSerializer.Serialize(res);
            return s;
        }

    }
}
