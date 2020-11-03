using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Demo2
{
    // or can use also an IOperation interface
    public interface IAudioFilter
    {
        public void apply(FormatSegment formatSegment);
        public void apply(FactSegment factSegment);
    }
}
