using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class CompressorWP
    {
        public void Compress(HttpRequest request) 
        {
            Console.WriteLine("Compress");
        }
    }
}
