using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SuperMap.Desktop;
using com.supermap.smb;

namespace OneDesktop
{
    public class DesktopPlugin : Plugin
    {
        public static SMBDelegate smbDelegate = null;

        public DesktopPlugin(PluginInfo pluginInfo)
            : base(pluginInfo)
        {

        }

        public override Boolean Initialize()
        {
            smbDelegate = new SMBDelegate(this);
            return true;
        }

        public static bool ConnectSMB()
        {
            if (smbDelegate == null)
            {
                //textStatus.Text = "连接对象不可用。";
                return false;
            }

            String strName = "com.supermap.desktop.net";
            String strExchange = "com.supermap.onedesktop";

            smbDelegate.setSender(strName);             // 发送者
            smbDelegate.setInExchange(strExchange);     // 接收频道
            smbDelegate.setTargetExchange(strExchange); // 目的频道

            //textStatus.Text ="开始检测网络...";
            smbDelegate.Connect("guest", "guest"); // 目前只能用guest/guest连接，以后会用strUserName/strPassword来验证用户的账户
            if (smbDelegate.getStatus() > 0)
            {
                //textStatus.Text = "已连接服务总线...";
            }
            else
            {
                //textStatus.Text = "连接服务总线失败！";
            }
            return true;
        }

        private static void SendMsg_Click()
        {
            if (smbDelegate == null)
            {
                //textStatus.Text = "连接对象不可用，请先连接。";
                return;
            }
            try
            {
                String strText = "Hello";    //textSend.Text;
                if (smbDelegate.getStatus() > 0)
                {
                    smbDelegate.PublishText(strText); // 发送文字消息

                    //textMsg.Text += "\r\n已发出>--" + strText;
                }
            }
            catch (Exception ex)
            {
                //textMsg.Text += "\r\n错误>>>" + ex.ToString();
            }
        }

        public void onSMBReceived(SMBMessage smbMsg)
        {
            //textMsg.Text += "\r\n收到>--"; //+ smbMsg.strSms;
            /*
            string msg = smbMsg.strSms;
            SetText("\r\n收到>--" + msg);
            if (msg == "show")
            {
                if (Globals.ThisAddIn.Application.Presentations.Count >= 1)
                {
                    PowerPoint.Presentation pr = Globals.ThisAddIn.Application.Presentations._Index(1);
                    pr.SlideShowSettings.Run();
                    //pr.SlideShowSettings.n
                }
            }
             */
        }

        delegate void SetTextCallback(string text);
        private static void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.

            //if (this.textMsg.InvokeRequired)
            //{
            //    SetTextCallback d = new SetTextCallback(SetText);
            //    this.Invoke(d, new object[] { text });
            //}
            //else
            //{
            //    this.textMsg.Text += text;
            //}
        }

        public override Boolean ExitInstance()
        {
            return true;
        }
    }
}
