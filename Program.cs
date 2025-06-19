using BugBase.Helpers;
using System;
using System.Data.Entity;
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
            // 👉 Set your custom initializer here
            //Database.SetInitializer(new DbInitilize());

            //using (var context = new AppDbContext())
            //{
            //    context.Database.Initialize(force: true);
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
