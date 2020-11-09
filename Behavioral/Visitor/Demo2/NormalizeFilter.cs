using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Demo2
{
    public class NormalizeFilter : IAudioFilter
    {
        public void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Normalize on format segment");
        }

        public void Apply(FactSegment factSegment)
        {
            Console.WriteLine("Normalize on fact segment");
        }
    }
}
