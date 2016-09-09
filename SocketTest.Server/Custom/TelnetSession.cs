using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase.Protocol;

namespace SocketTest.Server.Custom
{
    public class TelnetSession:AppSession<TelnetSession,ElecRequestInfo>
    {
      
        protected override void OnSessionStarted()
        {
            base.OnSessionStarted();
        }

        protected override void HandleUnknownRequest(ElecRequestInfo requestInfo)
        {
            base.HandleUnknownRequest(requestInfo);
        }

        protected override void HandleException(Exception e)
        {
            base.HandleException(e);
        }
    }
}
