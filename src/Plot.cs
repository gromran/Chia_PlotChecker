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
    public class Plot {

        public string Folder;
        public string FileName;

        //n, proofs
        public Dictionary<int, string> checkResult = new Dictionary<int, string>();

        public Plot(FileInfo file) {
            this.Folder = file.DirectoryName;
            this.FileName = file.Name;
        }

        public string SerializeToJSON() {

            NameValueCollection res = new NameValueCollection();

            res.Add("Folder", this.Folder);
            res.Add("FileName", this.FileName);

            //NameValueCollection res = new NameValueCollection();

            var s = JsonSerializer.Serialize(res);

            return s;
        }
    }

}
