using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProtocolHandler
{
    static class Program
    {
        public static string[] Arguments { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Arguments = args;
            ProtHelper fMain = new ProtHelper();
            fMain.Hide();
            
            if (!fMain.ProcessingComplete) Application.Run(fMain);
        }
    }
}
