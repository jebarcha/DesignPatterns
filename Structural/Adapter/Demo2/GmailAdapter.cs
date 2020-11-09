using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Demo2
{
    public class GmailAdapter : IEmailProvider
    {
        private GmailClient gmailClient = new GmailClient();
        public void DownloadEmails()
        {
            gmailClient.Connect();
            gmailClient.GetEmails();
            gmailClient.Disconnect();
        }
    }
}
