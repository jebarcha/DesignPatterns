using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Demo2
{
    public class Document
    {
        private String content;
        private String fontName;
        private int fontSize;

        public DocumentMemento CreateMemento()
        {
            return new DocumentMemento(content, fontName, fontSize);
        }
        public void Restore(DocumentMemento memento)
        {
            this.content = memento.getContent();
            this.fontName = memento.getFontName();
            this.fontSize = memento.getFontSize();
        }

        public String GetContent()
        {
            return content;
        }

        public void SetContent(String content)
        {
            this.content = content;
        }

        public String GetFontName()
        {
            return fontName;
        }

        public void SetFontName(String fontName)
        {
            this.fontName = fontName;
        }

        public int GetFontSize()
        {
            return fontSize;
        }

        public void SetFontSize(int fontSize)
        {
            this.fontSize = fontSize;
        }

        public override String ToString()
        {
            return "Document{" +
                    "content='" + content + '\'' +
                    ", fontName='" + fontName + '\'' +
                    ", fontSize=" + fontSize +
                    '}';
        }
    }
}
