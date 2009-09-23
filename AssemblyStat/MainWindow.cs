using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using AssemblyStat.BO;
using System.Diagnostics;

namespace AssemblyStat
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Assembly assembly = AssemblyManager.GetAssembly();
            if (AssemblyManager.IsDebuggable(assembly))
            {
                debuggableLabel.Text = "DEBUG";
            }
            else
            {
                debuggableLabel.Text = "RELEASE";
            }

            if (assembly != null)
            {
                AssemblyName name = assembly.GetName();
                nameTB.Text = name.FullName;
                foreach (AssemblyName reference in assembly.GetReferencedAssemblies())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = reference.Name;
                    item.SubItems.Add(reference.Version.ToString());
                    item.SubItems.Add(BitConverter.ToString(reference.GetPublicKeyToken()).Replace("-", "").ToLower());
                    assemblyList.Items.Add(item);
                }
                assemblyList.Sort();
            }
            else
            {
                Close();
            }
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
