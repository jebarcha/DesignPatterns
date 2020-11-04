using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class CaramelFilter : IFilter
    {
        // We are using composition because our CaramelFilter is composed of a Caramel object
        // Favor composition over inheritance because is more flexible in this case and
        // we could have our class composed by more than one object

        private Caramel caramel;

        public CaramelFilter(Caramel caramel)
        {
            this.caramel = caramel;
        }

        public void apply(Image image)
        {
            this.caramel.init();
            this.caramel.render(image);
        }
    }
}
