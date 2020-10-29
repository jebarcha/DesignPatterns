using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Transit : ITravelMode
    {
        public object getDirection()
        {
            Console.WriteLine("Calculating ETA (transit)");
            return 3;
        }

        public object getEta()
        {
            Console.WriteLine("Calculating Direction (transit)");
            return 3;
        }
    }
}
