using System;
using System.Windows.Forms;
using System.Diagnostics;
using Ookii.CommandLine;

namespace ProtocolHandler
{
    public partial class ProtHelper : Form
    {
        public bool ProcessingComplete { get; set; }

        private bool SpawnApp(string originalURI)
        {
            try
            {
                String oldProtocol = originalURI.Substring(0, originalURI.IndexOf(":"));
                System.Collections.Specialized.StringCollection ConfigList = Properties.Settings.Default.Apps;

                foreach (String Config in ConfigList)
                {
                    if (Config.ToUpper().StartsWith(oldProtocol.ToUpper() + "="))
                    {
                        string[] AppData = (Config.Split('='))[1].Split(',');
                        string App = AppData[0];
                        string newProtocol = AppData[1];
                        string newURI = newProtocol + originalURI.Substring(originalURI.IndexOf(":"), originalURI.Length - originalURI.IndexOf(":"));

                        Process p = new Process();
                        p.StartInfo.FileName = App;
                        p.StartInfo.Arguments = newURI;
                        p.Start();

                        return true;
                    }
                }
            }
            catch (Exception E)
            {
                Console.WriteLine("Failed to launch helper application, error {0}", E.Message);
            }
            return false;
        }

        public ProtHelper()
        {
            InitializeComponent();
            ProcessingComplete = false;

            try
            {
                CommandLineParser clp = new CommandLineParser(typeof(Options));
                Options O = (Options)clp.Parse(Program.Arguments);
                if (O.Help) this.Show();
                if (!String.IsNullOrEmpty(O.URI) && (SpawnApp(O.URI))) ProcessingComplete = true;
            }
            catch (CommandLineArgumentException)
            {
                ProcessingComplete = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessingComplete = true;
            Application.Exit();
        }
    }
}
