using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Walking : ITravelMode
    {
        public object getDirection()
        {
            Console.WriteLine("Calculating ETA (walking)");
            return 4;
        }

        public object getEta()
        {
            Console.WriteLine("Calculating Direction (walking)");
            return 4;
        }
    }
}
