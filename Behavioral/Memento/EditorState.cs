using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class EditorState
    {
        private readonly String content;
        public EditorState(string content)
        {
            this.content = content;
        }

        public String getContent() 
        {
            return content;
        }
    }
}
