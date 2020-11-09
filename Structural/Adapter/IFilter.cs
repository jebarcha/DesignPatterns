using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public interface IFilter
    {
        public void Apply(Image image);
    }
}
