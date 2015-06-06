using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProtocolHandler
{
    public partial class DefinedProtocols : Form
    {
        public DefinedProtocols()
        {
            InitializeComponent();
        }

        private void DefinedProtocols_Shown(object sender, EventArgs e)
        {
            ProtocolList.Items.Clear();

            foreach (var Config in Properties.Settings.Default.Apps)
            {
                string oldProtocol = (Config.Split('='))[0];
                string[] AppData = (Config.Split('='))[1].Split(',');
                string App = AppData[0];
                string newProtocol = AppData[1];

                ListViewItem LVI = new ListViewItem(oldProtocol);
                LVI.SubItems.Add(App);
                LVI.SubItems.Add(newProtocol);
                ProtocolList.Items.Add(LVI);
            }
        }
    }
}
