using System;
using System.Reflection;
using System.Windows.Forms;

namespace HTMLtoEXE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string resource1 = "HTMLtoEXE.Newtonsoft.Json.dll"; // Add more string resource# and
            EmbeddedAssembly.Load(resource1, "Newtonsoft.Json.dll"); // more embedded resource# if you have more then 1 dll

            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }
    }
}
