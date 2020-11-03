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

        public Connection connect(String ipAddress)
        {
            return new Connection();
        }

        public AuthToken authenticate(String appID, String key) 
        {
            return new AuthToken();
        }

        public void send(AuthToken authToken, Message message, String target) 
        {
            Console.WriteLine("Sending a message");
        }

    }
}
