using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;

namespace AssemblyStat.BO
{
    static class AssemblyManager
    {
        internal static string AssemblyPath
        {
            get;
            set;
        }

        internal static Assembly GetAssembly()
        {
            try
            {
                return Assembly.LoadFrom(AssemblyPath);
            }
            catch (BadImageFormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        internal static bool IsDebuggable(Assembly assembly)
        {
            // get custom attributes
            object[] attributes = assembly.GetCustomAttributes(typeof(DebuggableAttribute), true);
            
            // If the array is null, or has length of zero, then it is not debuggable.
            if (!(attributes == null || attributes.Length == 0))
            {
                // It is debuggable, figure out the level.
                DebuggableAttribute debug = (DebuggableAttribute) attributes[0];

                // At this point, you can access the DebuggingFlags property to determine the level of debugging.
                return debug.IsJITTrackingEnabled;
            }
            return false;
        }
    }
}
