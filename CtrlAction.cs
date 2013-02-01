using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SuperMap.Desktop;
using SuperMap.Data;
using com.supermap.smb;

namespace OneDesktop
{
    class ConnectCtrlAction : CtrlAction
    {
        override public void Run()
        {
            //MessageBox.Show("MyCtrlAction.Run");
            SuperMap.Desktop.Application.ActiveApplication.Output.Output("正在连接到协同服务器...");
            FormLogin frmlogin = new FormLogin();
            frmlogin.ShowDialog();

            //OneDesktop.DesktopPlugin.smbDelegate
        }

        public FormLogin frmlogin { get; set; }
    }

    class DialogueCtrlAction : CtrlAction
    {
        override public void Run()
        {            
            SuperMap.Desktop.Application.ActiveApplication.Output.Output("进入空间会话状态。");
            //SuperMap.Desktop.Application.ActiveApplication.MainForm.DockBarManager.
        }
    }

    class SyncViewCtrlAction : CtrlAction
    {
        override public void Run()
        {
            //MessageBox.Show("MyCtrlAction.Run");
            SuperMap.Desktop.Application.ActiveApplication.Output.Output("进入视图同步状态。");
            //SuperMap.Desktop.Application.ActiveApplication.MainForm.DockBarManager.
        }
    }

    
}
