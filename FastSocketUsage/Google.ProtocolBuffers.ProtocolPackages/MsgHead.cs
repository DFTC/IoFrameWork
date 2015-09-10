using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Protocols
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct MsgHead
    {
        /// <summary>
        /// protocol type
        /// </summary>
        public UInt32 MsgType;
        /// <summary>
        /// package legth include this struct size.
        /// </summary>
        public UInt32 MsgLen;
    }
}
