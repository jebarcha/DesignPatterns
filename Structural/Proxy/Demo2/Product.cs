using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Demo2
{
    public class Product
    {
        private int id;
        private String name;

        public Product(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public String GetName()
        {
            return name;
        }

        public void SetName(String name)
        {
            this.name = name;
        }
    }
}
