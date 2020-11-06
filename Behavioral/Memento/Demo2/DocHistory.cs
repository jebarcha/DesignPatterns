using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Demo2
{
    public class DocHistory
    {
        private Stack<DocumentMemento> mementos = new Stack<DocumentMemento>();

        public void Push(DocumentMemento memento)
        {
            mementos.Push(memento);
        }

        public DocumentMemento Pop()
        {
            return mementos.Pop();
        }
    }
}
