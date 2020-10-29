using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface IFilter
    {
        public void apply(String fileName);
    }
}
