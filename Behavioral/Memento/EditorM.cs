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
            content = state.GetContent();
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
