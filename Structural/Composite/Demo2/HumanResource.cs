using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Demo2
{
    public class HumanResource: Resource
    {
        public void deploy()
        {
            Console.WriteLine("Deploying a human resource");
        }
    }
}
