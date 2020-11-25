using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Demo2
{
    public abstract class AbstractUndoableCommand: IUndoableCommand
    {
        protected VideoEditor videoEditor;
        protected History history;
        public AbstractUndoableCommand(VideoEditor videoEditor, History history)
        {
            this.videoEditor = videoEditor;
            this.history = history;
        }

        public void Execute()
        {
            // Another application of the template method pattern. This method
            // is defining a template for executing commands.
            DoExecute();

            history.Push(this);
        }

        public abstract void Undo();
        protected abstract void DoExecute();
    }
}
