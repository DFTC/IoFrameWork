using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sodao.FastSocket.Client;
using Sodao.FastSocket.Client.Response;
using Sodao.FastSocket.Client.Protocol;
using Sodao.FastSocket.SocketBase;

namespace IoFrameWork
{
    public class TCPClient : PooledSocketClient<AsyncBinaryResponse>
    {
        #region Constructors
        /// <summary>
        /// new
        /// </summary>
        public TCPClient()
            : base(new AsyncBinaryProtocol())
        {
        }
        /// <summary>
        /// new
        /// </summary>
        /// <param name="socketBufferSize"></param>
        /// <param name="messageBufferSize"></param>
        public TCPClient(int socketBufferSize, int messageBufferSize)
            : base(new AsyncBinaryProtocol(), socketBufferSize, messageBufferSize, 3000, 3000)
        {
        }
        /// <summary>
        /// new
        /// </summary>
        /// <param name="socketBufferSize"></param>
        /// <param name="messageBufferSize"></param>
        /// <param name="millisecondsSendTimeout"></param>
        /// <param name="millisecondsReceiveTimeout"></param>
        public TCPClient(int socketBufferSize,
            int messageBufferSize,
            int millisecondsSendTimeout,
            int millisecondsReceiveTimeout)
            : base(new AsyncBinaryProtocol(),
            socketBufferSize,
            messageBufferSize,
            millisecondsSendTimeout,
            millisecondsReceiveTimeout)
        {

        }
        #endregion

        #region  override
        protected override void OnMessageReceived(IConnection connection, MessageReceivedEventArgs e)
        {
            base.OnMessageReceived(connection, e);
            Console.WriteLine("received message.");
            if (MessageReceived != null)
            {
                MessageReceived(connection, e);
            }
        }
        protected override void Send(Request<AsyncBinaryResponse> request)
        {
            base.Send(request);
            Console.WriteLine("Send: CmdName"+request.CmdName);
        }
        #endregion

        #region  public methods
        public void SendMessage(string cmdName,Packet packet,Action<Exception> onException,Action<AsyncBinaryResponse> onResult)
        {
            Request<AsyncBinaryResponse> req = new Request<AsyncBinaryResponse>(base.NextRequestSeqID(), cmdName, packet.Payload, onException, onResult);
            this.Send(req);
        }
        #endregion
        #region event
        public event MessageReceivedHandler MessageReceived;
        #endregion
    }
}
