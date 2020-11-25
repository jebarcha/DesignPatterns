using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Demo2
{
    public class SetTextCommand: AbstractUndoableCommand
    {
        private String text;

        public SetTextCommand(String text, VideoEditor videoEditor, History history): base(videoEditor, history)
        {
            this.text = text;
        }
        public override void Undo()
        {
            videoEditor.RemoveText();
        }

        protected override void DoExecute()
        {
            videoEditor.SetText(text);
        }
    }
}
