using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Editor
{
    public class HtmlDocument
    {
        private String content;
        public void MakeBold() 
        {
            content = "<b>" + content + "</b>";
        }
        public String GetContent() 
        {
            return content;
        }
        public void SetContent(String content) 
        {
            this.content = content;
        }

    }
}
