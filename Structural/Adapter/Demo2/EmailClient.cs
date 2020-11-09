using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Demo2
{
    public class EmailClient
    {
        private List<IEmailProvider> providers = new List<IEmailProvider>();

        public void AddProvider(IEmailProvider provider)
        {
            providers.Add(provider);
        }

        public void DownloadEmails()
        {
            foreach (var provider in providers)
                provider.DownloadEmails();
        }
    }
}
