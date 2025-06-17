using BugBase.Helpers;
using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BugBase
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
