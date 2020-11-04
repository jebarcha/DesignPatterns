using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class VividFilter : IFilter
    {
        public void apply(Image image)
        {
            Console.WriteLine("Apply vivid filter to " + image);
        }
    }
}
