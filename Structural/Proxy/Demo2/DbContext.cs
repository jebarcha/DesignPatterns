using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Demo2
{
    public class DbContext
    {
        private Dictionary<int, Product> updatedObjects = new Dictionary<int, Product>();

        public Product getProduct(int id)
        {
            // Automatically generate SQL statements
            // to read the product with the given ID.
            Console.WriteLine("SELECT * FROM products WHERE product_id = %d \n", id);

            // Simulate reading a product object from a database.
            var product = new ProductProxy(id, this);
            product.setName("Product 1");

            return product;
        }

        public void saveChanges()
        {
            // Automatically generate SQL statements
            // to update the database.
            foreach (var updatedObject in updatedObjects.Values)
                Console.WriteLine("UPDATE products SET name = '%s' WHERE product_id = %d \n", updatedObject.getName(), updatedObject.getId());

            updatedObjects.Clear();
        }

        public void markAsChanged(Product product)
        {
            updatedObjects.Add(product.getId(), product);
        }
    }
}
