using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Demo2
{
    public class QuickBooksReader : DataReader
    {
        protected override void DoRead(string fileName)
        {
            Console.WriteLine("Reading data from a QuickBooks file.");
        }

        protected override string GetExtension()
        {
            return ".qbw";
        }
    }
}
