using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.Text;
using AssemblyStat.BO;
using System.Collections.Specialized;

namespace AssemblyStat
{
    static class Program
    {
        static string ParseAssebly(AssemblyName name)
        {
            return name.Version.ToString();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string []args)
        {
            CommandLineParser parser = new CommandLineParser();
            
            StringDictionary parameters =  parser.ParseParams(args);

            AssemblyManager.AssemblyPath = parameters[Consts.AllowedParameters.Assembly];

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
