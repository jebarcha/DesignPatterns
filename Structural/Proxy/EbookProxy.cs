using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class EbookProxy : IEBook
    {
        private String fileName;
        private RealEBook ebook;
        public EbookProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public string GetFileName()
        {
            return fileName;
        }

        public void Show()
        {
            if (ebook == null)
            {
                ebook = new RealEBook(fileName);
            }
            ebook.Show();
        }
    }
}
