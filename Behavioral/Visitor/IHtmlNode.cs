using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IHtmlNode
    {
        public void execute(IOperation operation);  
    }
}
