using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    // This is also called IVisitor
    // We should use this patter if our object structure is very stable
    public interface IOperation
    {
        public void apply(HeadingNode heading);
        public void apply(AnchorNode anchor);
    }
}
