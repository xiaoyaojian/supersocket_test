using SuperSocket.Facility.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketTest.Server.Custom
{
    public class ElecReceiveFilter : FixedHeaderReceiveFilter<ElecRequestInfo>
    {
        public ElecReceiveFilter() : base(2)
        {

        }

        protected override int GetBodyLengthFromHeader(byte[] header, int offset, int length)
        {
            if (header[offset] == 0xab && header[offset] == 0xbc)
            {
                return 74 - 2;
            }
            else if (header[offset] == 0x68)
            {
                return header[offset + 1];
            }
            else
            {
                return length;
            }
        }

        protected override ElecRequestInfo ResolveRequestInfo(ArraySegment<byte> header, byte[] bodyBuffer, int offset, int length)
        {
            ElecRequestInfo info = new ElecRequestInfo();

            return info;
        }
    }
}
