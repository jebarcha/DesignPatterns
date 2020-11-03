using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Demo2
{
    public class ReverbFilter : IAudioFilter
    {
        public void apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Reverb filter on format segment");
        }

        public void apply(FactSegment factSegment)
        {
            Console.WriteLine("Reverb filter on fact segment");
        }
    }
}
