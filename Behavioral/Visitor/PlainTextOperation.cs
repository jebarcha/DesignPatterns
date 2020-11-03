using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class PlainTextOperation : IOperation
    {
        public void apply(HeadingNode heading)
        {
            Console.WriteLine("text-heading");
        }

        public void apply(AnchorNode anchor)
        {
            Console.WriteLine("text-anchor");
        }
    }
}
