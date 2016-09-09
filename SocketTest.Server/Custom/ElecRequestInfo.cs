using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketTest.Server.Custom
{
    public class ElecRequestInfo : IRequestInfo
    {
        public string Key { get; set; }
        public byte[] Body { get; set; }
    }
}
