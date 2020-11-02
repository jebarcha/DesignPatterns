using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface IPushObserver
    {
        public void update(int value);   // we can have objects, but for simplicity we're using int type.
    }
}
