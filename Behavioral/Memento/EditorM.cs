using System;

namespace Memento
{
    public class EditorM
    {
        private String content;
        public EditorState CreateState() 
        {
            return new EditorState(content);
        }
        public void Restore(EditorState state) 
        {
            content = state.getContent();
        }



        public String getContent()
        {
            return content;
        }
        public void setContent(String content) 
        {
            this.content = content;
        }


    }
}
