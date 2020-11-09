using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Demo2
{
    public abstract class Segment
    {
        public abstract void ApplyFilter(IAudioFilter filter);

    }
}
