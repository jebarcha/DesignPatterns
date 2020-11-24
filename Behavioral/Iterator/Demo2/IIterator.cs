using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Demo2
{
    public interface IIterator
    {
        bool HasNext();
        Product Current();
        void Next();
    }
}
