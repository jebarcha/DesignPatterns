using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class NotificationServer1
    {
        // connect() -> Connection
        // authenticate(appID, key) -> AuthToken
        // send(authToken, message, target)
        // conn.disconnect()

        public Connection Connect(String ipAddress)
        {
            return new Connection();
        }

        public AuthToken Authenticate(String appID, String key) 
        {
            return new AuthToken();
        }

        public void Send(AuthToken authToken, Message message, String target) 
        {
            Console.WriteLine("Sending a message");
        }

    }
}
