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
                String oldProtocol = originalURI.Substring(0, originalURI.IndexOf(":")).ToLower();
                string Remainder = originalURI.Substring(originalURI.IndexOf(":"), originalURI.Length - originalURI.IndexOf(":"));

                Handler H = Configurator.GetHandler(oldProtocol);
                if (H == null)
                {
                    return false;
                }
                else
                {
                    Process p = new Process();
                    p.StartInfo.FileName = H.Application;
                    p.StartInfo.Arguments = H.Protocol + Remainder;
                    p.Start();

                    return true;
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

        private void QuitButton_Click(object sender, EventArgs e)
        {
            ProcessingComplete = true;
            Application.Exit();
        }

        private void ShowProtsButton_Click(object sender, EventArgs e)
        {
            DefinedProtocols DPView = new DefinedProtocols();
            DPView.ShowDialog();
        }

    }
}
