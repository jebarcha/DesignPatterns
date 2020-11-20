using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Demo2
{
    public class DataReaderWithTheProblem
    {
        public void read(String fileName)
        {
            if (fileName.EndsWith(".xls"))
            {
                Console.WriteLine("Reading data from an Excel spreadsheet.");
            }
            else if (fileName.EndsWith(".numbers"))
            {
                Console.WriteLine("Reading data from a Numbers spreadsheet.");
            }
            else if (fileName.EndsWith(".qbw"))
            {
                Console.WriteLine("Reading data from a QuickBooks file.");
            }
            else
                throw new ArgumentException("File format not supported.");
        }
    }
}
