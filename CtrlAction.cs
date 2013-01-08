using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SuperMap.Desktop;
using SuperMap.Data;

namespace OneDesktop
{
    class ConnectCtrlAction : CtrlAction
    {
        override public void Run()
        {
            //MessageBox.Show("MyCtrlAction.Run");
            SuperMap.Desktop.Application.ActiveApplication.Output.Output("正在连接到协同服务器...");
        }
    }

    class SyncViewCtrlAction : CtrlAction
    {
        override public void Run()
        {
            //MessageBox.Show("MyCtrlAction.Run");
            SuperMap.Desktop.Application.ActiveApplication.Output.Output("进入视图同步状态。");
        }
    }

    
}
