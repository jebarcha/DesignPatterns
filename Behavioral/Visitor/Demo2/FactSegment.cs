using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Demo2
{
    public class FactSegment: Segment
    {
        public override void ApplyFilter(IAudioFilter filter)
        {
            filter.Apply(this);
        }
    }
}
