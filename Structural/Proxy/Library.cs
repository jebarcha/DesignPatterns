using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class Library
    {
        private Dictionary<String, IEBook> ebooks = new Dictionary<String, IEBook>();
        public void Add(IEBook ebook) 
        {
            ebooks.Add(ebook.GetFileName(), ebook);
        }

        public void OpenEbook(String fileName) 
        {
            ebooks[fileName].Show();
        }
    }
}
