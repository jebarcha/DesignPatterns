using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class HeadingNode : IHtmlNode
    {
        public void execute(IOperation operation)
        {
            operation.apply(this);
        }
    }
}
