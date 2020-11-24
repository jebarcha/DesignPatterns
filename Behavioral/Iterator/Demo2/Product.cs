using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Demo2
{
    public class Product
    {
        private int id;
        private String name;

        public Product(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
        public override String ToString()
        {
            return $"Product id={id}, name={name}";
        }
    }
}
