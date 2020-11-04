using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Demo2
{
    public class GmailAdapter : IEmailProvider
    {
        private GmailClient gmailClient = new GmailClient();
        public void downloadEmails()
        {
            gmailClient.connect();
            gmailClient.getEmails();
            gmailClient.disconnect();
        }
    }
}
