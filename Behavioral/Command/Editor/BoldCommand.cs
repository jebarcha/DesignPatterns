using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Editor
{
    public class BoldCommand : IUndoableCommand
    {
        private String prevContent;
        private HtmlDocument document;
        private History history;

        public BoldCommand(HtmlDocument document, History history)
        {
            this.document = document;
            this.history = history;
        }

        public void Execute()
        {
            prevContent = document.GetContent();
            document.MakeBold();
            history.Push(this);
        }

        public void Unexecute()
        {
            document.SetContent(prevContent);
        }
    }
}
