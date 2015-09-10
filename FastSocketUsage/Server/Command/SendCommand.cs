using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sodao.FastSocket.Server;
using Sodao.FastSocket.Server.Command;
using Sodao.FastSocket.SocketBase;

namespace Server
{
    public class SendCommand : ICommand<AsyncBinaryCommandInfo>
    {
        public string Name
        {
            get
            {
                return "send";
            }
        }
        /// <summary>
        /// 处理命令
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="commandInfo"></param>
        public void ExecuteCommand(IConnection connection, AsyncBinaryCommandInfo commandInfo)
        {
            //throw new NotImplementedException();
            byte[] bytes = System.Text.ASCIIEncoding.Default.GetBytes("this is send command.");
            commandInfo.Reply(connection, bytes);
        }
    }
}
