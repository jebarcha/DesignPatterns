using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class Library
    {
        private Dictionary<String, IEBook> ebooks = new Dictionary<String, IEBook>();
        public void add(IEBook ebook) 
        {
            ebooks.Add(ebook.getFileName(), ebook);
        }

        public void openEbook(String fileName) 
        {
            ebooks[fileName].show();
        }
    }
}
