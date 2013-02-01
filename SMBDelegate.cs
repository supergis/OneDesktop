using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using com.supermap.smb;

namespace OneDesktop
{
    public class SMBDelegate
    {
        private SMBClient m_SMBClient = null;

        private String m_strSender = "";
        private String m_strInExchange = "";
        private String m_strTargetExchange = "";
        public String m_strMQServer = "42.120.50.220";

        UCDialogue m_Panel = null;

        public SMBDelegate(UCDialogue mainHandler) 
        {
            m_Panel = mainHandler;

            m_SMBClient = new SMBClient();
            m_SMBClient.SMBMessageReceived += onSMBReceived;     // 指定 接收并处理消息的 回调函数
            m_SMBClient.SMBStatusChanged += onSMBStatusChanged;  // 指定 接收并处理状态变化的 回调函数
	    }

        public bool Connect( String strUserName, String strPassword)
        { // 连接消息服务，需要根据回传的状态信息才能判断是否连接成功，参见 onSMBStatusChanged(...)方法
            m_SMBClient.setSender( m_strSender );                    // 发送者
            m_SMBClient.setInExchange(m_strInExchange);              // 接收频道
            m_SMBClient.setTargetExchange( m_strTargetExchange );    // 目的频道

            m_SMBClient.setExtServer(m_strMQServer);

            return m_SMBClient.Connect(strUserName, strPassword);    // 目前只能用guest/guest连接，以后会用strUserName/strPassword来验证用户的账户
        }

        public void onSMBStatusChanged(int nStatus)
        { // 接收并处理状态变化的函数，将作为回调函数传给底层，参见 Connect(...)方法
          // 回传的状态 nStatus 值的含义： 0--正在连接中； 1--已经连接成功
            if (nStatus == 0)
            {
                m_Panel.onSMBStatus("连接中...");
                System.Console.WriteLine("连接中...");  // 在此仅仅简单地在命令行窗口中输出信息而已
            }
            else if (nStatus == 1)
            {
                m_Panel.onSMBStatus("已连接！");
                System.Console.WriteLine("已连接！"); // 在此仅仅简单地在命令行窗口中输出信息而已
            }
        }

        public void onSMBReceived(SMBMessage smbMsg)
        {// 接收并处理消息的函数，将作为回调函数传给底层，参见 Connect(...)方法
            if (smbMsg != null)
            {
                String strMsg = smbMsg.strSender + ":";
                if (smbMsg.strLocation != null)
                { // 位置信息
                    strMsg += "&"+smbMsg.strLocation+"&";
                }

                if (smbMsg.strSms != null)  
                { // 文字信息
                    strMsg += smbMsg.strSms;
                }

                if (smbMsg.strCommand != null)
                //if ((strMsg.Length>2)&(strMsg.Substring(0,1)=="^"))
                {
                    //控制命令
                    //string strResult = "EXEC Result: " + CSMBCMD.ExecCMD(smbMsg.strCommand);
                    //PublishText(strResult);
                }

                m_Panel.onSMBReceived(smbMsg);
                //invoke(
                System.Console.WriteLine(strMsg);   // 在此仅仅简单地在命令行窗口中输出信息而已

            }
        }

	    public int getStatus() 
        { // 获取当前状态信息, 0--连接中； 1--已连接
		    if (m_SMBClient != null) {
			    return m_SMBClient.getStatus();
		    } else {
			    return 0;
		    }
	    }    	
        
        public void setMQServer(String strMQServer)
        {
            if (strMQServer != null && strMQServer.Length > 0)
            {
                m_strMQServer = strMQServer;
            }
        }        

	    public void setSender( String strSender )
        {// 设置 发送者
		    m_strSender = strSender;
	    }

        public void setInExchange(String strInExchange)
        { // 设置 接收频道
            m_strInExchange = strInExchange;
        }

	    public void setTargetExchange( String strTargetExchange )
        { // 设置 目的频道
		    m_strTargetExchange = strTargetExchange;
	    }

	    public void PublishText(String strText)
        { // 发送 文本信息
		    if (m_SMBClient != null) 
            {
			    m_SMBClient.PublishText(strText);
		    }
	    }

        public void PublishLocation(double x, double y, double z, double dSpeed, double dBearing, int nOption)
        { // 发送 位置信息
            if (m_SMBClient != null)
            {
                m_SMBClient.PublishLocation(x, y, z, dSpeed, dBearing, nOption);
            }
        }

    }
}
