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
            var connection = server.connect("ip");
            var authToken = server.authenticate("appID", "key");
            server.send(authToken, new Message("Hello World"), target);
            connection.disconnect();
        }

    }

}
