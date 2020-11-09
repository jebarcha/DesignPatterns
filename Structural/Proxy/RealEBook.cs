using System;

namespace Proxy
{
    public class RealEBook : IEBook
    {
        private String fileName;

        public RealEBook(string fileName)
        {
            this.fileName = fileName;
            Load();
        }

        private void Load()
        {
            Console.WriteLine("Loading the ebook " + fileName);
        }

        public void Show()
        {
            Console.WriteLine("Showing the ebook " + fileName);
        }
        public String GetFileName()
        {
            return fileName;
        }
    }
}
