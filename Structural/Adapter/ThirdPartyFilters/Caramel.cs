using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter //.ThirdPartyFilters
{
    public class Caramel
    {
        public void Init() 
        {
            // to use this library we need to call first init() method

        }

        public void Render(Image image) 
        {
            Console.WriteLine("Apply caramel filter");
        }

    }
}
