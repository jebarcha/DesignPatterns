using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Demo2
{
    public class NumbersReader : DataReader
    {
        protected override void DoRead(string fileName)
        {
            Console.WriteLine("Reading data from a Numbers spreadsheet: ");
        }

        protected override string GetExtension()
        {
            return ".numbers";
        }
    }
}
