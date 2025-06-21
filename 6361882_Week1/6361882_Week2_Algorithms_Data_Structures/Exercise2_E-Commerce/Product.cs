using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
    public class Product
    {
        public int ProductId;
        public string ProductName;
        public string Category;

        public Product(int id, string name, string cat)
        {
            ProductId = id;
            ProductName = name;
            Category = cat;
        }
    }
}