using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Demo2
{

    public class WavFile 
    {
        private List<Segment> segments = new List<Segment>();

        public static WavFile read(String fileName)
        {
            // Simulate reading a wav file and building the segments
            var wavFile = new WavFile();
            wavFile.segments.Add(new FormatSegment());
            wavFile.segments.Add(new FactSegment());
            wavFile.segments.Add(new FactSegment());
            wavFile.segments.Add(new FactSegment());

            return wavFile;
        }

        public void applyFilter(IAudioFilter filter)
        {
            foreach (var segment in segments)
                segment.applyFilter(filter);
        }
    }
}
