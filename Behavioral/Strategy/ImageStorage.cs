using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ImageStorage
    {
        public void Store(String fileName, ICompressor compressor, IFilter filter) 
        {
            compressor.Compress(fileName);

            filter.Apply(fileName);

        }
    }
}
