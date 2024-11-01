using System;
using System.Windows.Forms;

namespace Tiny_language_project
{
    internal static class Program
    {
        /// <summary>
        /// The Main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Loading_form());
            Application.Run(new Loading_form());
        }
    }
}
