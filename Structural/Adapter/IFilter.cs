using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public interface IFilter
    {
        public void apply(Image image);
    }
}
