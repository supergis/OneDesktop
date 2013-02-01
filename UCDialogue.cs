using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using com.supermap.smb;

namespace OneDesktop
{
    public partial class UCDialogue : UserControl
    {
        SMBDelegate smbDelegate = null;

        public UCDialogue()
        {
            InitializeComponent();

            smbDelegate = new SMBDelegate(this);

        }

        private void tbConnect_Click(object sender, EventArgs e)
        {
            //FormLogin frmlogin = new FormLogin();
            //frmlogin.ShowDialog();

            if (smbDelegate == null)
            {
                textStatus.Text = "连接对象不可用。";
                return;
            }

            String strName = "Deskpro.NET";
            String strExchange = "smGasMonitor";

            smbDelegate.setSender(strName);             // 发送者
            smbDelegate.setInExchange(strExchange);     // 接收频道
            smbDelegate.setTargetExchange(strExchange); // 目的频道

            textStatus.Text = "开始检测网络...";
            smbDelegate.Connect("guest", "guest"); // 目前只能用guest/guest连接，以后会用strUserName/strPassword来验证用户的账户
    
            //for (int i = 0; i < 10; i++)
            //{
            //    if (smbDelegate.getStatus() > 0)
            //    {
            //        textStatus.Text = "已连接服务总线...";
            //        //break;
            //    }
            //    else
            //    {
            //        textStatus.Text = "连接服务总线失败！"; // + String.Format("第d%次",i);
            //    }                
            //}

        }       
	
        private void tbSendMsg_Click(object sender, EventArgs e)
        {
            if (smbDelegate == null)
            {
                textStatus.Text = "连接对象不可用，请先连接。";
                return;
            }
            try
            {
                String strText = textMsgInput.Text;
                if (smbDelegate.getStatus() > 0)
                {
                    smbDelegate.PublishText(strText); // 发送文字消息

                    textMsg.Text += "\r\n已发出>--" + strText;
                }
            }
            catch (Exception ex)
            {
                textMsg.Text += "\r\n错误>>>" + ex.ToString();
            }
        }

        public void onSMBStatus(String smbStatus)
        {
            textStatus.Text = smbStatus;
        }

        public void onSMBReceived(SMBMessage smbMsg)
        {
            //textMsg.Text += "\r\n收到>--"; //+ smbMsg.strSms;

            string msg = smbMsg.strSms;

            textStatus.Text = "收到：" + msg;

            SetText("\r\n收到>--" + msg);

            if (msg == "show")
            {
                //if (Globals.ThisAddIn.Application.Presentations.Count >= 1)
                //{
                //    PowerPoint.Presentation pr = Globals.ThisAddIn.Application.Presentations._Index(1);
                //    pr.SlideShowSettings.Run();
                //    //pr.SlideShowSettings.n
                //}
            }
        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textMsg.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textMsg.Text += text;
            }
        }

    }
}
