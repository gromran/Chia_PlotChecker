using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PlotChecker.src
{
    [Serializable]
    public class Plot {

        public string Folder;
        public string FileName;

        //n, proofs
        public Dictionary<int, int> checkResult = new Dictionary<int, int>();

        public Plot(FileInfo file) {
            this.Folder = file.DirectoryName;
            this.FileName = file.Name;
        }
        public Plot() { }

    }

}
