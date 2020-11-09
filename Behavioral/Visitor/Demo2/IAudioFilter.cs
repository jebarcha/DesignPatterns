using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Demo2
{
    // or can use also an IOperation interface
    public interface IAudioFilter
    {
        public void Apply(FormatSegment formatSegment);
        public void Apply(FactSegment factSegment);
    }
}
