using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Demo2
{
    public class DocumentMemento
    {
        private readonly String content;
        private readonly String fontName;
        private readonly int fontSize;

        public DocumentMemento(String content, String fontName, int fontSize)
        {
            this.content = content;
            this.fontName = fontName;
            this.fontSize = fontSize;
        }

        public String getContent()
        {
            return content;
        }

        public String getFontName()
        {
            return fontName;
        }

        public int getFontSize()
        {
            return fontSize;
        }
    }
}
