using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    // this is playing the role of Mediator
    // in this example, every time a ui control change its state it will call this DialogBox
    public abstract class DialogBox
    {
        public abstract void Changed(UIControl control);
    }
}
