using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlotChecker.src
{
    class Checker
    {
        //public Dictionary<string, Task> taskList = new Dictionary<string, Task>(5);

        public static async Task CheckPlotsAsync(Dictionary<string, Plot> pList) {
            foreach (var item in pList)
            {
                Console.WriteLine(item.Value.FileName);
                MessageBox.Show(item.Value.Folder);
            }
        }

        public static Dictionary<string, Plot> CheckPlots(Dictionary<string, Plot> pList, int n = 30)
        {
            foreach (var item in pList)
            {

                var processStartInfo = new ProcessStartInfo();
                processStartInfo.CreateNoWindow = true;
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.RedirectStandardError = true;
                processStartInfo.RedirectStandardInput = true;
                processStartInfo.UseShellExecute = false;
                processStartInfo.Arguments = "plots check -n "+n.ToString()+" -g " + item.Value.FileName;
                processStartInfo.FileName = @"C:\Users\Gromran\AppData\Local\chia-blockchain\app-1.1.7\resources\app.asar.unpacked\daemon\chia.exe";

                var process = Process.Start(processStartInfo);
                var output = process.StandardError.ReadToEnd();
                process.WaitForExit();

                var t = Regex.Match(output, "(?<=Proofs )([0-9]){1,5}");

                if (t.Success)
                {
                    if (!item.Value.checkResult.ContainsKey(n))
                    {
                        item.Value.checkResult.Add(n, int.Parse(t.Value));
                    } else {
                        item.Value.checkResult[n] = int.Parse(t.Value);
                    }
                } else {
                    if (!item.Value.checkResult.ContainsKey(n))
                    {
                        item.Value.checkResult.Add(n, 0);
                    }
                    else
                    {
                        item.Value.checkResult[n] = 0;
                    }
                }

               // break;



            }
            return pList;
        }

    }

}
