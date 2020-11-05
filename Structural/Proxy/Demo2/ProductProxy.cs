using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Demo2
{
    public class ProductProxy: Product
    {
        private DbContext context;

        public ProductProxy(int id, DbContext context): base(id)
        {
            this.context = context;
        }

        public void setName(String name)
        {
            base.setName(name);

            context.markAsChanged(this);
        }
    }
}
