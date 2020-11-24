using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public interface IIterator<T>   // Generic interface, so can accept any type
    {
        bool HasNext();
        T Current();  // Generic
        void Next();
    }
}
