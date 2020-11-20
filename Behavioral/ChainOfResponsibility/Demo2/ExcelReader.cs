using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Demo2
{
    public class ExcelReader : DataReader
    {
        protected override void DoRead(string fileName)
        {
            Console.WriteLine("Reading data from an Excel spreadsheet.");
        }

        protected override string GetExtension()
        {
            return ".xls";
        }
    }
}
