using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Compress : IStream
    {
        private IStream stream;
        public Compress(IStream stream)
        {
            this.stream = stream;
        }

        public void Write(string data)
        {
            var compressed = Compress1(data);
            stream.Write(compressed);
        }

        private String Compress1(String data)
        {
            return data.Substring(0, 5);
        }
    }
}
