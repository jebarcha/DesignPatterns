using System;

namespace Bridge
{
    // Basic Remote Control (turnOn, turnOff)
    // Advanced Remote Control (additional features like setChannel, etc.)
    // Movie Remote Control (play, pause, rewind, etc.)

    // our Hierarchy would be like:
    // RemoteControl
    //   SonyRemoteControl
    //   SamsungRemoteControl
    //   AdvancedRemoteControl
    //     SonyAdvancedRemoteControl
    //     SamsungAdvancedRemoteControl

    // Currently we have 2 remote control and if we want to support a new remote control
    // we have to add 2 new classes for every new brand we add.

    public class RemoteControl
    {
        protected IDevice device;  // this field is the bridge between these 2 separate hirarchies
        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        // We don't know the specific implementation of TurnOn() and TurnOff() because
        // it depends on the TV model, sony, samsung, etc.
        public void TurnOn() 
        {
            device.TurnOn();
        }
        public void TurnOff()
        {
            device.TurnOff();
        }
    }
}
