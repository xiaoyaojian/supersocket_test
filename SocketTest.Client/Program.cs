using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketTest.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint endpoint = new IPEndPoint(ip, 6001);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(endpoint);

            byte[] atCommand = new byte[74];
            atCommand[0] = 0xab;
            atCommand[1] = 0xbc;
            Random r = new Random(DateTime.Now.Millisecond);
            for(var i = 2; i < 74; i++)
            {
                atCommand[i] = (byte)(r.Next() % 256);
            }
            socket.Send(atCommand);//发送长度为74  头部为ab bc的一条指令  (ab bc开的的指令固定长度为74)

            byte[] elec104 = new byte[10];
            elec104[0] = 0x68;
            elec104[1] = 0x03;
            elec104[2] = 0x12;
            elec104[3] = 0x12;
            elec104[4] = 0x12;
            socket.Send(elec104);//发送头部为 68 ** 的一条指令  **代表指令长度

            Console.ReadKey();
        }
    }
}
