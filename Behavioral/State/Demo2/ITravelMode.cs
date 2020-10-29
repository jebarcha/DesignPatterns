using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public interface ITravelMode
    {
        public Object getEta();
        public Object getDirection();
    }
}
