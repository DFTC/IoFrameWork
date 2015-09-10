using Sodao.FastSocket.Client.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sodao.FastSocket.SocketBase;
using IoFrameWork.Response;

namespace IoFrameWork.Protocols
{
    public sealed class DSSBinaryProtocol : IProtocol<DSSBinaryResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="buffer"></param>
        /// <param name="readlength"></param>
        /// <returns></returns>
        public DSSBinaryResponse FindResponse(IConnection connection, ArraySegment<byte> buffer, out int readlength)
        {
            throw new NotImplementedException();
        }
    }
}
