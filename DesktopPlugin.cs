using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SuperMap.Desktop;

namespace OneDesktop
{
    public class DesktopPlugin : Plugin
    {
        public DesktopPlugin(PluginInfo pluginInfo)
            : base(pluginInfo)
        {

        }

        public override Boolean Initialize()
        {
            return true;
        }

        public override Boolean ExitInstance()
        {
            return true;
        }
    }
}
