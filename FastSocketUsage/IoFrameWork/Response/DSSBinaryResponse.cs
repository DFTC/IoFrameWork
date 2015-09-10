using Sodao.FastSocket.Client.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IoFrameWork.Response
{
    public class DSSBinaryResponse : IResponse
    {
        private int _seqID;
        public int SeqID
        {
            get
            {
            return this._seqID;
            }
        }
        public readonly string Flag = null;
        public readonly byte[] Buffer = null;

        public DSSBinaryResponse(byte[] buffer,string flag,int seqID)
        {
            Buffer = buffer;
            Flag = flag;
            seqID = _seqID;
        }
    }
}
