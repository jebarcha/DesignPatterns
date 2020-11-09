using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Demo2
{
    public class DbContext
    {
        private Dictionary<int, Product> updatedObjects = new Dictionary<int, Product>();

        public Product GetProduct(int id)
        {
            // Automatically generate SQL statements
            // to read the product with the given ID.
            Console.WriteLine("SELECT * FROM products WHERE product_id = %d \n", id);

            // Simulate reading a product object from a database.
            var product = new ProductProxy(id, this);
            product.SetName("Product 1");

            return product;
        }

        public void SaveChanges()
        {
            // Automatically generate SQL statements
            // to update the database.
            foreach (var updatedObject in updatedObjects.Values)
                Console.WriteLine("UPDATE products SET name = '%s' WHERE product_id = %d \n", updatedObject.GetName(), updatedObject.GetId());

            updatedObjects.Clear();
        }

        public void MarkAsChanged(Product product)
        {
            updatedObjects.Add(product.GetId(), product);
        }
    }
}
