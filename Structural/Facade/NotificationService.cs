using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class NotificationService
    {
        public void send(String message, String target)
        {
            var server = new NotificationServer1();
            var connection = server.Connect("ip");
            var authToken = server.Authenticate("appID", "key");
            server.Send(authToken, new Message("Hello World"), target);
            connection.Disconnect();
        }

    }

}
