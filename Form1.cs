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
            File.WriteAllText(site + "mainElectron.js", "const { app,BrowserWindow } = require('electron');\r\n\r\nlet win;\r\n\r\nfunction createWindow () {\r\n  win = new BrowserWindow({\r\n    width: "+textBox4.Text+",\r\n    height: "+textBox5.Text+",\r\n    webPreferences: {\r\n      nodeIntegration: true\r\n    }\r\n  });\r\n\r\n  win.loadFile('index.html');\r\n  win.on('closed', () => {\r\n    win = null\r\n  });\r\n  win.autoHideMenuBar = true;\r\n  win.resizable = false;\r\n}\r\n\r\napp.on('ready', createWindow);\r\n\r\napp.on('window-all-closed', () => {\r\n  if (process.platform !== 'darwin') {\r\n    app.quit();\r\n  }\r\n});\r\n\r\napp.on('activate', () => {\r\n  if (win === null) {\r\n    createWindow();\r\n  }\r\n});\r\n");

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

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
