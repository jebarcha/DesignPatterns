using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class TextBox : UIControl
    {
        private String content;

        public TextBox(DialogBox owner) : base(owner)
        {
        }

        public String GetContent()
        {
            return content;
        }
        public void SetContent(String content) 
        {
            this.content = content;
            owner.Changed(this);
        }
    } 
}
