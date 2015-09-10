using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using protocol;
using Protocols;

namespace Google.ProtocolBuffers.ProtocolPackages.Common
{
    public class PacketHeadHelper
    {
        /// <summary>
        /// 添加包头
        /// </summary>
        /// <param name="type">package type</param>
        /// <param name="content">package content with byte array</param>
        /// <returns></returns>
        public static byte[] ContentAddHead(HeadType type, byte[] content)
        {
            MsgHead head = new MsgHead();
            head.MsgType = (UInt32)IPAddress.HostToNetworkOrder((int)type);
            int contentLenght = content.Length;
            int size = Marshal.SizeOf(head);

            head.MsgLen = (UInt32)IPAddress.HostToNetworkOrder(contentLenght);
            byte[] bytes_head = new byte[size];
            IntPtr buffer = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(head, buffer, false);
            Marshal.Copy(buffer, bytes_head, 0, size);
            Marshal.FreeHGlobal(buffer);
            byte[] package = new byte[content.Length + bytes_head.Length];
            Array.Copy(bytes_head, 0, package, 0, bytes_head.Length);
            Array.Copy(content, 0, package, bytes_head.Length, content.Length);
            return package;
        }
        public static byte[] ContentRemoveHead(byte[] content)
        {
            MsgHead head = new MsgHead();
            int size = Marshal.SizeOf(head);
            byte[] dd = new byte[size];
            Array.Copy(content, 0, dd, 0, dd.Length);
            IntPtr intPtr = Marshal.AllocHGlobal(dd.Length);
            try
            {
                Marshal.Copy(dd, 0, intPtr, dd.Length);
                head = (MsgHead)Marshal.PtrToStructure(intPtr, head.GetType());
            }
            catch
            {

            }
            byte[] packet = new byte[IPAddress.NetworkToHostOrder((int)head.MsgLen)];
            Array.Copy(content,size, packet, 0, packet.Length);
            return packet;
        }
    }
}
