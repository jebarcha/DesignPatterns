using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Demo2
{
    public class FactSegment: Segment
    {
        public override void applyFilter(IAudioFilter filter)
        {
            filter.apply(this);
        }
    }
}
