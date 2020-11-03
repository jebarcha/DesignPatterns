using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Demo2
{
    public class NoiseReductionFilter : IAudioFilter
    {
        public void apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Noise reduction on format segment");
        }

        public void apply(FactSegment factSegment)
        {
            Console.WriteLine("Noise reduction on fact segment");
        }
    }
}
