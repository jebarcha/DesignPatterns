using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class PushChart : IPushObserver
    {
        public void Update(int value)
        {
            Console.WriteLine("Chart got Updated: " + value);
        }
    }
}
