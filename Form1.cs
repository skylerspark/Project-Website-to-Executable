using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace HTMLtoEXE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string template = Application.StartupPath + "\\TemplateApp\\";
        string site = Application.StartupPath + "\\Site\\";

        private void Extract(string fileName)
        {
            Directory.CreateDirectory(Application.StartupPath + "\\Site");
            if (Directory.GetFiles(site, "*.html").Length == 0)
            {
                ZipFile.ExtractToDirectory(fileName, site);
            }
            else
            {
                DirectoryInfo di = new DirectoryInfo(site);

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
                ZipFile.ExtractToDirectory(fileName, site);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string newFilePath = openFileDialog1.FileName;
                MessageBox.Show(newFilePath);
                Extract(newFilePath);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Application.StartupPath + "\\Site");
            File.WriteAllBytes(site + "package.json", Properties.Resources.package);
            File.WriteAllText(site + "mainElectron.js", Properties.Resources.mainElectron);

            string json = File.ReadAllText(site + "package.json");
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            jsonObj["name"] = textBox1.Text;
            jsonObj["version"] = textBox2.Text;
            jsonObj["author"] = textBox3.Text;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(site + "package.json", output);

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WorkingDirectory = site;
            // startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C npm i electron --save-dev";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();

            Process process2 = new Process();
            ProcessStartInfo startInfo2 = new ProcessStartInfo();
            startInfo2.WorkingDirectory = site;
            // startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo2.FileName = "cmd.exe";
            startInfo2.Arguments = "/C electron-builder .";
            process2.StartInfo = startInfo2;
            process2.Start();
            process2.WaitForExit();

            MessageBox.Show("Thanks for using WTE! Your Executable is located in:\n"+site+"dist\\ElectronApp.exe");
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://nodejs.org/en/download/");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            // startInfo.WorkingDirectory = site;
            // startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C npm i electron-builder -g";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();

            MessageBox.Show("electron builder has been installed on your computer ^_^");
        }
    }
}
