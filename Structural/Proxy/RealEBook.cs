using System;

namespace Proxy
{
    public class RealEBook : IEBook
    {
        private String fileName;

        public RealEBook(string fileName)
        {
            this.fileName = fileName;
            load();
        }

        private void load()
        {
            Console.WriteLine("Loading the ebook " + fileName);
        }

        public void show()
        {
            Console.WriteLine("Showing the ebook " + fileName);
        }
        public String getFileName()
        {
            return fileName;
        }
    }
}
