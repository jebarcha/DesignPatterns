using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class ListBox : UIControl
    {
        private String selection;

        public ListBox(DialogBox owner) : base(owner)
        {
        }

        public String GetSelection() 
        {
            return selection;
        }
        public void SetSelection(String sel) 
        { 
            this.selection = sel;
            owner.Changed(this);
        }
    }
}
