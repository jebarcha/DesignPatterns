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

        public void SetName(String name)
        {
            base.SetName(name);

            context.MarkAsChanged(this);
        }
    }
}
