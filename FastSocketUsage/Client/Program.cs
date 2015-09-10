using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IoFrameWork;
using protocol;
using Google.ProtocolBuffers.ProtocolPackages.Common;
namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            int socketBufferSize = 8192;
            int messageBufferSize = 8192;
            int sendTimeOut = 3000;
            int receiveTimeOut = 3000;
            var client = new TCPClient(socketBufferSize, messageBufferSize, sendTimeOut, receiveTimeOut);
            //注册服务器节点，这里可注册多个(name不能重复）
            //client.RegisterServerNode("127.0.0.1:8401", new System.Net.IPEndPoint(System.Net.IPAddress.Parse("127.0.0.1"), 8401));
            client.RegisterServerNode("GoServer", new System.Net.IPEndPoint(System.Net.IPAddress.Parse("192.168.1.46"), 6543));
            CliLoginPreReq preReq = CliLoginPreReq.CreateBuilder().SetUsrName("chen").Build();
            byte[] message = PacketHeadHelper.ContentAddHead(HeadType.CLI_LOGIN_PRE_REQ, preReq.ToByteArray());
            //client.MessageReceived += Client_MessageReceived;
            
            //发送预登陆消息
            client.SendMessage("QQ", new Sodao.FastSocket.SocketBase.Packet(message), e =>
            {

                Console.WriteLine(e.Message);
            }, result =>
            {

                string resultStr = System.Text.ASCIIEncoding.Default.GetString(result.Buffer);
                Console.WriteLine(resultStr);
            });
            //发送登录请求
            CliLoginReq req = CliLoginReq.CreateBuilder().SetUsrName("chen").SetPassword("pass").Build();
            byte[] messageReq = PacketHeadHelper.ContentAddHead(HeadType.CLI_LOGIN_REQ, req.ToByteArray());
            client.SendMessage("QQ", new Sodao.FastSocket.SocketBase.Packet(messageReq), e =>
            {

                Console.WriteLine(e.Message);
            }, result =>
            {

                string resultStr = System.Text.ASCIIEncoding.Default.GetString(result.Buffer);
                Console.WriteLine(resultStr);
            });
            Console.WriteLine("send success.");
            Console.ReadLine();
        }

        private static void Client_MessageReceived(Sodao.FastSocket.SocketBase.IConnection connection, Sodao.FastSocket.SocketBase.MessageReceivedEventArgs e)
        {
            CliLoginPreRsp rsp = CliLoginPreRsp.ParseFrom(PacketHeadHelper.ContentRemoveHead(e.Buffer.Array));
            Console.WriteLine("Message Receiveed：Code=" + rsp.Code + ",Key=" + rsp.Key);
        }
    }
}
