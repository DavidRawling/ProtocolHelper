using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text;
using System.ComponentModel;

namespace ProtocolHandler
{
    class Configurator
    {
        public static Handler GetHandler(string Name)
        {
            AppConfiguration appC = ConfigurationManager.GetSection("appConfiguration") as AppConfiguration;
            HandlerSet HandlerElements = AppConfiguration.Instance.Handlers;

            if (HandlerElements == null || HandlerElements.Count < 1)
                return null;

            return HandlerElements[Name];
        }

        public static HandlerSet GetAllHandlers()
        {
            AppConfiguration appC = ConfigurationManager.GetSection("appConfiguration") as AppConfiguration;
            return AppConfiguration.Instance.Handlers;
        }

        public static void SetAllHandlers(BindingList<Handler> Handlers)
        {
            Configuration Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppConfiguration appC = Config.GetSection("appConfiguration") as AppConfiguration;
            HandlerSet HS = new HandlerSet();
            
            foreach (Handler HE in Handlers)
                HS.Add(HE);

            appC.Handlers = HS;
            Config.Save(ConfigurationSaveMode.Minimal);
            ConfigurationManager.RefreshSection("appConfiguration");
        }
    }
}
