using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProtocolHandler
{
    public partial class DefinedProtocols : Form
    {
        BindingList<Handler> Handlers;

        public DefinedProtocols()
        {
            InitializeComponent();
        }

        private void DefinedProtocols_Shown(object sender, EventArgs e)
        {
            HandlerSet HC = Configurator.GetAllHandlers();
            Handlers = new BindingList<Handler>();

            foreach (Handler H in HC)
                Handlers.Add(H);

            ProtocolDGV.DataSource = Handlers;

            for (int i = 3; i < ProtocolDGV.Columns.Count; i++)
                ProtocolDGV.Columns[i].Visible = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Configurator.SetAllHandlers(Handlers);
        }
    }
}
