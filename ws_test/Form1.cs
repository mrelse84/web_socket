using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace ws_test
{
    public partial class Form1 : Form
    {
        private WebSocketServer webSocketServer = null;
        String srv_log = "";

        private Client client;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartSrv_Click(object sender, EventArgs e)
        {
            if (webSocketServer != null)
                return;

            Int32 port = 4649;
            webSocketServer = new WebSocketServer(port);
            //webSocketServer.AddWebSocketService<Echo>("/Echo");
            webSocketServer.AddWebSocketService<Chat>("/Chat");
            webSocketServer.Start();
            srv_log += "서버시작\n";
        }

        private void btnStopSrv_Click(object sender, EventArgs e)
        {
            if (webSocketServer != null)
                webSocketServer.Stop();

            webSocketServer = null;
            srv_log += "서버종료\n";
        }

        public class Client
        {
            private WebSocket mWebSocket;
            Form _mainFrm = null;

            public Client(Form mainFrm)
            {
                _mainFrm = mainFrm;
                StartConnect();
            }
            public void StartConnect()
            {
                mWebSocket = new WebSocket("ws://localhost:4649/Chat");
                mWebSocket.OnOpen += (sender, e) =>
                {
                    mWebSocket.Send("Hi, there!");
                };
                mWebSocket.OnMessage += (sender, e) =>
                {
                    Console.WriteLine(e.Data);
                    //((Form1)_mainFrm).richTxtClientLog.AppendText(e.Data);
                };
                mWebSocket.Connect();
            }
            public void SendMessage(string msg)
            {
                mWebSocket.Send("nickname: " + msg);
            }
        }

        private void btnStartClient_Click(object sender, EventArgs e)
        {
            client = new Client(this);
        }
    }
}
