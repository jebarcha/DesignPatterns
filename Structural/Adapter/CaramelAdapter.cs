using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    // We are extending (or inheriting) a Caramel class and implementing IFilter interface.
    public class CaramelAdapter : Caramel, IFilter
    {
        // Here instead of composition, we are using inheritance. This is valid too.
        // So we use inheritance to implment an adapter
        // However this approach is not as flexible as using composition
        // because in C# or Java We don't have multiple inheritance (means a class only can have a single parent)
        public void apply(Image image)
        {
            init();
            render(image);
        }
    }
}
