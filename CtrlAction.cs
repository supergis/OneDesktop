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
            SuperMap.Desktop.Application.ActiveApplication.Output.Output("�������ӵ�Эͬ������...");
        }
    }

    class SyncViewCtrlAction : CtrlAction
    {
        override public void Run()
        {
            //MessageBox.Show("MyCtrlAction.Run");
            SuperMap.Desktop.Application.ActiveApplication.Output.Output("������ͼͬ��״̬��");
        }
    }

    
}
