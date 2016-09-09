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
            IPAddress ip = IPAddress.Parse("192.168.96.199");
            IPEndPoint endpoint = new IPEndPoint(ip, 6001);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(endpoint);

            byte[] atCommand = new byte[74];
            atCommand[0] = 171;
            atCommand[1] = 188;
            atCommand[2] = 205;
            Random r = new Random(DateTime.Now.Millisecond);
            for(var i = 3; i < 74; i++)
            {
                atCommand[i] = (byte)(r.Next() % 256);
            }
            socket.Send(atCommand);

            byte[] elec104 = new byte[10];
            elec104[0] = 104;
            elec104[1] = 3;
            elec104[2] = 12;
            elec104[3] = 12;
            elec104[4] = 12;
            socket.Send(elec104);

            Console.ReadKey();
        }
    }
}
