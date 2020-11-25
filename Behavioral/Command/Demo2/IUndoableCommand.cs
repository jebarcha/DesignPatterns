using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Demo2
{
    public interface IUndoableCommand
    {
        public void Undo();
    }
}
