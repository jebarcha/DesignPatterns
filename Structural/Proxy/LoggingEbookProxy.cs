using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class LoggingEbookProxy : IEBook
    {
        private String fileName;
        private RealEBook ebook;

        public LoggingEbookProxy(string fileName)
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
            Console.WriteLine("Logging");
            ebook.Show();
        }
    }
}
