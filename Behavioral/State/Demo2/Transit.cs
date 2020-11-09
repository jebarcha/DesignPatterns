using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Transit : ITravelMode
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating ETA (transit)");
            return 3;
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating Direction (transit)");
            return 3;
        }
    }
}
