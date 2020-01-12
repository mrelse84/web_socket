using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace ws_test
{
    public class Chat : WebSocketBehavior
    {
        //public Chat()
        //{
        //    //_prefix = !prefix.IsNullOrEmpty() ? prefix : "anon#";
        //}

        protected override void OnMessage(MessageEventArgs e)
        {
            var text = e.Data;
            text += "\n";
            //richTxtLog.AppendText(text);

            Sessions.Broadcast(e.Data);
        }
    }
}
