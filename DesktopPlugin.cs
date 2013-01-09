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
                //textStatus.Text = "���Ӷ��󲻿��á�";
                return false;
            }

            String strName = "com.supermap.desktop.net";
            String strExchange = "com.supermap.onedesktop";

            smbDelegate.setSender(strName);             // ������
            smbDelegate.setInExchange(strExchange);     // ����Ƶ��
            smbDelegate.setTargetExchange(strExchange); // Ŀ��Ƶ��

            //textStatus.Text ="��ʼ�������...";
            smbDelegate.Connect("guest", "guest"); // Ŀǰֻ����guest/guest���ӣ��Ժ����strUserName/strPassword����֤�û����˻�
            if (smbDelegate.getStatus() > 0)
            {
                //textStatus.Text = "�����ӷ�������...";
            }
            else
            {
                //textStatus.Text = "���ӷ�������ʧ�ܣ�";
            }
            return true;
        }

        private static void SendMsg_Click()
        {
            if (smbDelegate == null)
            {
                //textStatus.Text = "���Ӷ��󲻿��ã��������ӡ�";
                return;
            }
            try
            {
                String strText = "Hello";    //textSend.Text;
                if (smbDelegate.getStatus() > 0)
                {
                    smbDelegate.PublishText(strText); // ����������Ϣ

                    //textMsg.Text += "\r\n�ѷ���>--" + strText;
                }
            }
            catch (Exception ex)
            {
                //textMsg.Text += "\r\n����>>>" + ex.ToString();
            }
        }

        public void onSMBReceived(SMBMessage smbMsg)
        {
            //textMsg.Text += "\r\n�յ�>--"; //+ smbMsg.strSms;
            /*
            string msg = smbMsg.strSms;
            SetText("\r\n�յ�>--" + msg);
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
