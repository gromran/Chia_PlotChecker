using Newtonsoft.Json;
using PlotChecker.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlotChecker
{
    public partial class Form1 : Form
    {

        private Dictionary<string, Folder> folderList = new Dictionary<string, Folder>();

        private BackgroundWorker backgroundWorker1 = new BackgroundWorker();

        public Form1()
        {
            InitializeComponent();
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(this.backgroundWorker1_ProgessChanged);
            this.backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker1_Completed);

        }

        private void backgroundWorker1_ProgessChanged(object sender, ProgressChangedEventArgs e) {
            progressBar1.PerformStep();
        }
        private void backgroundWorker1_Completed(object sender, RunWorkerCompletedEventArgs e) {
            this.FillPlotList();
            progressBar1.Visible = false;
            btnCheckPlots.Enabled = true;
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK) {
                string hash = Tools.GetMD5HashFromString(fbd.SelectedPath);
                if (!folderList.ContainsKey(hash))
                {
                    Folder f = new Folder(fbd.SelectedPath);
                    folderList.Add(Tools.GetMD5HashFromString(f.fullPath), f);
                    clBFolders.Items.Add(fbd.SelectedPath, true);
                    this.saveData();
                }
            }
        }

        private void saveData() {
            File.Delete(Application.StartupPath + "/folders.json");
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            using (StreamWriter sw = new StreamWriter(Application.StartupPath + "/folders.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, folderList);
            }
        }

        private void BtnCheckPlots_Click(object sender, EventArgs e)
        {
            /*
            int count = 0;
            foreach (var item in folderList) {
                count += item.Value.plotList.Count;
            }
            progressBar1.Maximum = count;
            */
            progressBar1.Maximum = folderList.Count;
            progressBar1.Visible = true;
            ((Button)sender).Enabled = false;

            List<Object> args = new List<object>();
            args.Add(folderList);
            args.Add((int)numericUpDown_nValue.Value);
            backgroundWorker1.RunWorkerAsync(args);
            //FillPlotList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string json = File.ReadAllText(Application.StartupPath + "/folders.json");
            if (json.Length > 0)
            {
                folderList = JsonConvert.DeserializeObject<Dictionary<string, Folder>>(File.ReadAllText(Application.StartupPath + "/folders.json"));
                foreach (var item in folderList)
                {
                    clBFolders.Items.Add(item.Value.fullPath, true);
                }
                FillPlotList();

            }
        }

        private void FillPlotList() {
            listView_Plots.Items.Clear();
            foreach (var item in folderList)
            {
                var firstItem = true;

                foreach (Plot p in item.Value.plotList.Values)
                {
                    if (firstItem == true)
                    {
                        firstItem = false;
                        listView_Plots.Columns.Clear();

                        List<ColumnHeader> ch = new List<ColumnHeader>();


                        ch.Add(new ColumnHeader()
                        {
                            Text = "plot"
                        });
                        ch.Add(new ColumnHeader()
                        {
                            Text = "folder"
                        });

                        foreach (var n in p.checkResult)
                        {
                            ch.Add(new ColumnHeader()
                            {
                                Text = n.Key.ToString()
                            });

                        }


                        listView_Plots.Columns.AddRange(ch.ToArray());

                    }

                    ListViewItem lvi = new ListViewItem(p.FileName);
                    lvi.SubItems.Add(p.Folder);
                    foreach (var n in p.checkResult)
                    {
                        lvi.SubItems.Add(n.Value.ToString());
                    }

                    listView_Plots.Items.Add(lvi);
                }

            }
        }


        private void BtnScanForPlots_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var item in folderList)
            {
                item.Value.scanForPlots();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.saveData();
        }



        private void ClBFolders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Object> args = (List<Object>)e.Argument;

            BackgroundWorker helperBW = sender as BackgroundWorker;

            foreach (var item in (Dictionary<string, Folder>)args[0])
            {
                item.Value.plotList = Checker.CheckPlots(item.Value.plotList, (int)args[1]);
                helperBW.ReportProgress(1);
                if (helperBW.CancellationPending)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
