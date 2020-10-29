using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class JpegCompressor : ICompressor
    {
        public void compress(string fileName)
        {
            Console.WriteLine("Compressing using JPEG");
        }
    }
}
