using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class PngCompressor : ICompressor
    {
        void ICompressor.Compress(string fileName)
        {
            Console.WriteLine("Compressing using PNG");
        }
    }
}
