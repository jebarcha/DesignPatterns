using Bridge.WithTheProblem;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class SonyAdvancedRemoteControl : AdvRemoteControl
    {
        public override void SetChannel(int number)
        {
            Console.WriteLine("Sony: SetChannel");
        }
        public override void TurnOn()
        {
            Console.WriteLine("Sony: TurnOn");
        }
        public override void TurnOff()
        {
            Console.WriteLine("Sony: TurnOff");
        }

    }
}
