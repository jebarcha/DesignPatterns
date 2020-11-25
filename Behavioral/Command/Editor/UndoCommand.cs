using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Editor
{
    public class UndoCommand : ICommandAction
    {
        private History history;
        public UndoCommand(History history)
        {
            this.history = history;
        }

        public void Execute()
        {
            if (history.Size() > 0) 
            {   
                history.Pop().Unexecute();
            }
        }
    }
}
