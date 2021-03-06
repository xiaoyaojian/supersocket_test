﻿using SuperSocket.Facility.Protocol;
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
            if (header[offset] == 171)
            {
                return 72;
            }
            else if(header[offset]==104)
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
