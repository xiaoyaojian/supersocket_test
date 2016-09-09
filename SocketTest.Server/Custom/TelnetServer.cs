using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketTest.Server.Custom
{
    public class TelnetServer:AppServer<TelnetSession,ElecRequestInfo>
    {
        public TelnetServer():base(new DefaultReceiveFilterFactory<ElecReceiveFilter, ElecRequestInfo>())
        {

        }
        protected override void OnNewSessionConnected(TelnetSession session)
        {
            base.OnNewSessionConnected(session);
        }
    }
}
