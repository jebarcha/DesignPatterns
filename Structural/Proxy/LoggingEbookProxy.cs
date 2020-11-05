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
            Console.WriteLine("Logging");
            ebook.show();
        }
    }
}
