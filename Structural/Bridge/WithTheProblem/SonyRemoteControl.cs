using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class SonyRemoteControl : RemoteControlWithProblem
    {
        // in a real life app, here we would use the 3rd party library to talk to a Sony tv
        public override void TurnOff()
        {
            Console.WriteLine("Sony: TurnOn");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Sony: TurnOff");
        }
    }
}
