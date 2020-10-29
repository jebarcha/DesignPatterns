using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ImageStorage
    {
        public void store(String fileName, ICompressor compressor, IFilter filter) 
        {
            compressor.compress(fileName);

            filter.apply(fileName);

        }
    }
}
