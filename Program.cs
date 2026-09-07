using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalManagementSystem._Forms;

namespace CarRentalManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string mdfPath = System.IO.Path.Combine(baseDir, "car_rental.mdf");

            if (!System.IO.File.Exists(mdfPath))
            {
                string current = baseDir;
                for (int i = 0; i < 4; i++)
                {
                    string candidate = System.IO.Path.Combine(current, "car_rental.mdf");
                    if (System.IO.File.Exists(candidate))
                    {
                        mdfPath = System.IO.Path.GetFullPath(candidate);
                        break;
                    }
                    var parent = System.IO.Directory.GetParent(current);
                    if (parent == null) break;
                    current = parent.FullName;
                }
            }

            if (System.IO.File.Exists(mdfPath))
            {
                AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Path.GetDirectoryName(mdfPath));
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Login());
        }

    }
}
