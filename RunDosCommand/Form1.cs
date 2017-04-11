using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace RunDosCommand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtGPSPFile.Text))
            {
                MessageBox.Show("GPSP file does not exist");
                return;
            }
                
            if (!File.Exists(txtINIFile.Text))
            {
                MessageBox.Show("ini file does not exist");
                return;
            }
            if (!Directory.Exists(txtLogFolder.Text))
            {
                MessageBox.Show("Log folder does not exist");
                return;
            }
            Process myProcess = new Process();
            TimeSpan tsNum = dtpEnding.Value - dtpBeginning.Value;
            int numDaily = (int) tsNum.TotalDays + 1;

            myProcess.StartInfo.FileName = txtGPSPFile.Text;

            //Do not receive an event when the process exits.
            myProcess.EnableRaisingEvents = false;

            //myProcess.StartInfo.CreateNoWindow = true;
            myProcess.StartInfo.CreateNoWindow = false;
            myProcess.StartInfo.UseShellExecute = true;
            //myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;

            DateTime dtDaily = dtpBeginning.Value;

            for (int i = 0; i < numDaily; i++)
            {
                try
                {
                    
                    // Parameters
                    //myProcess.StartInfo.Arguments = @"C:\ELT\Live\Server\Edulognt.cfg 1 0 1 1 1 1";
                    

                    myProcess.StartInfo.Arguments = txtINIFile.Text + " " + dtDaily.ToString("MM/dd/yyyy");
                    

                    myProcess.Start();

                    int milisecondToWait = 600000; // 10 minute
                    myProcess.WaitForExit(milisecondToWait);

                    //myProcess.WaitForExit(milisecondToWait);

                    ////check the fStopGeo.txt file
                    ////To get the location the assembly normally resides on disk or the install directory
                    //string path = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;

                    ////once you have the path you get the directory with:
                    //string directory = System.IO.Path.GetDirectoryName(path);

                    string resultFile = txtLogFolder.Text + "\\" + dtDaily.ToString("MMddyyyy") + "-postprocess.log";
                    //int milisecondToWait = 600000;
                    int count = 0;
                    bool founded = false;
                    while (count < 30)
                    {
                        count++;
                        if (File.Exists(resultFile))
                        {
                            ////get this stop infor node1 node2, d1, d2
                            //StringBuilder sb = new StringBuilder();
                            ////bool containt = false;

                            //StreamReader reader = new StreamReader("");
                            //string line = reader.ReadLine();
                            ////bool containt = false;
                            ////string[] stopInfor;
                            break;
                        }
                        else
                            Thread.Sleep(1000);
                    }

                    dtDaily = dtDaily.AddDays(1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message);
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGPSPFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "*|*.exe";
            openFileDialog1.Title = "Select a PostProcess.exe file";

            string filePath;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                txtGPSPFile.Text = filePath;
            }
        }

        private void btnINIFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "*|*.ini";
            openFileDialog2.Title = "Select a gpsp.ini file";            

            string filePath;
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = openFileDialog2.FileName;
                txtINIFile.Text = filePath;
            }
        }

        private void btnLogFolder_Click(object sender, EventArgs e)
        {
            //String folder;
            //FolderBrowserDialog fbd = new FolderBrowserDialog();
            ////fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            //if (fbd.ShowDialog() == DialogResult.OK)
            //{
            //    folder = fbd.SelectedPath;
            //    txtLogFolder.Text = fbd.SelectedPath;
            //}

            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "*|*.*";
            openFileDialog2.Title = "Select a any file in log folder";

            string filePath;
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = Path.GetDirectoryName(openFileDialog2.FileName);
                txtLogFolder.Text = filePath;
            }
        }
    }
}
