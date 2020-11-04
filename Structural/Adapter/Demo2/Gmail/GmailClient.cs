using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Demo2
{
    public class GmailClient
    {
        public void connect()
        {
            Console.WriteLine("Connecting to Gmail");
        }

        public void getEmails()
        {
            Console.WriteLine("Downloading emails from Gmail");
        }

        public void disconnect()
        {
            Console.WriteLine("Disconnecting from Gmail");
        }
    }
}
