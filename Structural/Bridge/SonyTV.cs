using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class SonyTV : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Sony: Turn On");
        }
        public void TurnOff()
        {
            Console.WriteLine("Sony: Turn Off");
        }
        public void SetChannel(int number)
        {
            Console.WriteLine("Sony: SetChannel " + number);
        }

    }
}
