using SocketTest.Server.Custom;
using SuperSocket.SocketBase;
using SuperSocket.SocketEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketTest.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            //var server = new TelnetServer();
            //server.Setup(6001);
            //server.Start();

            //Console.ReadKey();


            var bootstrap = BootstrapFactory.CreateBootstrap();
            if (!bootstrap.Initialize())
            {
                Console.WriteLine("Initialize error");
            }
            var result = bootstrap.Start();
            if (result == StartResult.Success)
            {
                Console.WriteLine("Start completed");
            }
            else
            {
                Console.WriteLine("Start error");
            }

            Console.ReadKey();
            bootstrap.Stop();
        }
    }
}
