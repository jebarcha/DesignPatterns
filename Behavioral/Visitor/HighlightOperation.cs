using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class HighlightOperation : IOperation
    {
        public void apply(HeadingNode heading)
        {
            Console.WriteLine("highlight heading");
        }

        public void apply(AnchorNode anchor)
        {
            Console.WriteLine("highlight anchor");
        }
    }
}
