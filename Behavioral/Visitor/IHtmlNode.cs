using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IHtmlNode
    {
        public void Execute(IOperation operation);  
    }
}
