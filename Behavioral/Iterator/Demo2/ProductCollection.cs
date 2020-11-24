using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Demo2
{
    public class ProductCollection
    {
        private List<Product> products = new List<Product>();

        public void Add(Product product)
        {
            products.Add(product);
        }

        public IIterator CreateIterator()
        {
            return new ListIterator(this);
        }

        private class ListIterator : IIterator
        {
            private ProductCollection collection;
            private int index;

            public ListIterator(ProductCollection collection)
            {
                this.collection = collection;
            }

            public bool HasNext()
            {
                return (index < collection.products.Count);
            }

            public Product Current()
            {
                return collection.products[index];
            }

            public void Next()
            {
                index++;
            }
        }
    }
}
