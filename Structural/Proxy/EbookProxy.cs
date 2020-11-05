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

        public string getFileName()
        {
            return fileName;
        }

        public void show()
        {
            if (ebook == null)
            {
                ebook = new RealEBook(fileName);
            }
            ebook.show();
        }
    }
}
