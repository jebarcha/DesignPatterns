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

        public void write(string data)
        {
            var compressed = compress(data);
            stream.write(compressed);
        }

        private String compress(String data)
        {
            return data.Substring(0, 5);
        }
    }
}
