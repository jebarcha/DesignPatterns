﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("Apply B&W filter");
        }
    }
}
