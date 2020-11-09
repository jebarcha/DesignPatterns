using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface ICompressor
    {
        // byte[] compress(byte[] image);
        public void Compress(String fileName);
 
    }
}
