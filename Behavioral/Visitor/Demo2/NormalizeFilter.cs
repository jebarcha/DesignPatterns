using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Demo2
{
    public class NormalizeFilter : IAudioFilter
    {
        public void apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Normalize on format segment");
        }

        public void apply(FactSegment factSegment)
        {
            Console.WriteLine("Normalize on fact segment");
        }
    }
}
