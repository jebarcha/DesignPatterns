using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class PushChart : IPushObserver
    {
        public void update(int value)
        {
            Console.WriteLine("Chart got Updated: " + value);
        }
    }
}
