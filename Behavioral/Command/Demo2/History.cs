using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Demo2
{
    public class History
    {
        private List<IUndoableCommand> commands = new List<IUndoableCommand>();

        public void Push(IUndoableCommand command)
        {
            commands.Add(command);
        }

        public IUndoableCommand Pop()
        {
            var lastIndex = commands.Count - 1;
            var cmd = commands[lastIndex];
            commands.RemoveAt(lastIndex);
            return cmd;
        }

        public int Size()
        {
            return commands.Count;
        }
    }
}
