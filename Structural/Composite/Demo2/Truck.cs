﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Demo2
{
    public class Truck: Resource
    {
        public void Deploy()
        {
            Console.WriteLine("Deploying a truck");
        }
    }
}
