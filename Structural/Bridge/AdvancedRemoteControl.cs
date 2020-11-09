using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    // Feature hierarchy where we have 2 types of remote controls
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device)
        {
            
        }
        public void SetChannel(int number)
        {
            device.SetChannel(number);
        }

    }
}
