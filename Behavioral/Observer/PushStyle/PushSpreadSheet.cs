using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class PushSpreadSheet : IPushObserver
    {
        public void Update(int value)
        {
            Console.WriteLine("Spreadsheet got notified: " + value);
        }
    }
}
