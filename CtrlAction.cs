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
            SuperMap.Desktop.Application.ActiveApplication.Output.Output("�������ӵ�Эͬ������...");
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
            SuperMap.Desktop.Application.ActiveApplication.Output.Output("����ռ�Ự״̬��");
            //SuperMap.Desktop.Application.ActiveApplication.MainForm.DockBarManager.
        }
    }

    class SyncViewCtrlAction : CtrlAction
    {
        override public void Run()
        {
            //MessageBox.Show("MyCtrlAction.Run");
            SuperMap.Desktop.Application.ActiveApplication.Output.Output("������ͼͬ��״̬��");
            //SuperMap.Desktop.Application.ActiveApplication.MainForm.DockBarManager.
        }
    }

    
}
