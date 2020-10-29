using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Driving : ITravelMode
    {
        public object getDirection()
        {
            Console.WriteLine("Calculating ETA (driving)");
            return 1;
        }

        public object getEta()
        {
            Console.WriteLine("Calculating Direction (driving)");
            return 1;
        }
    }
}
