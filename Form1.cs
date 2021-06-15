using PlotChecker.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PlotChecker
{
    public partial class Form1 : Form
    {

        HashSet<Folder> folderList = new HashSet<Folder>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK) {
                if (folderList.Add(new Folder(fbd.SelectedPath)))
                {
                    clBFolders.Items.Add(fbd.SelectedPath, true);
                }
                this.saveData();
            }
        }

        private void saveData() {
            File.Delete(Application.StartupPath + "/folders.json");
            var t = File.AppendText(Application.StartupPath + "/folders.json");
            foreach (var item in folderList)
            {
                //var s = JsonSerializer.Serialize(item);
                var s = item.SerializeToJSON();
                t.WriteLine(s);
            }
            t.Close();
        }

        private void BtnCheckPlots_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string json = File.ReadAllText(Application.StartupPath + "/folders.json");
            if (json.Length > 0)
            {

                foreach (var foo in File.ReadLines(Application.StartupPath + "/folders.json")) {
                    //folderList.Add(JsonSerializer.Deserialize<Folder>(foo));
                }
                foreach (Folder f in folderList)
                {
                    clBFolders.Items.Add(f.fullPath, true);
                }
            }
        }

        private void BtnScanForPlots_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var item in folderList)
            {
                item.scanForPlots();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.saveData();
        }
    }
}
