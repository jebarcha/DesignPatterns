using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class HighContrastFilter : IFilter
    {
        public void apply(string fileName)
        {
            Console.WriteLine("Apply High-Contrast filter");
        }
    }
}
