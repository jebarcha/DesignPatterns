using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class AnchorNode : IHtmlNode
    {
        public void execute(IOperation operation)
        {
            operation.apply(this);
        }
    }
}
