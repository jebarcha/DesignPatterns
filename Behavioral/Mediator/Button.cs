using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class Button: UIControl
    {
        private bool isEnabled;

        public Button(DialogBox owner) : base(owner)
        {
        }

        public bool IsEnabled() 
        {
            return isEnabled;
        }
        public void SetEnabled(bool isEnabled) 
        {
            this.isEnabled = isEnabled;
            owner.Changed(this);
        }
    }
}
