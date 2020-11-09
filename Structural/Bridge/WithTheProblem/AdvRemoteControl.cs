using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.WithTheProblem
{
    // Hierarchy is:
    // RemoteControl
    //   SonyRemoteControl
    //   AdvancedRemoteControl
    //     SonyAdvancedRemoteControl

    public abstract class AdvRemoteControl: RemoteControlWithProblem
    {
        public abstract void SetChannel(int number);
    }
}
