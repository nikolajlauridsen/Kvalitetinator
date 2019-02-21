using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesLib.Model;

namespace SalesLib.Domain
{
    class Product : IProduct
    {
        public string Name { get; }

        public string Description { get; }

        public double Price { get; }

        public int MinInStock { get; }

        public Product(string name, string description, double price, int minInStock)
        {
            Name = name;
            Description = description;
            Price = price;
            MinInStock = minInStock;
        }
    }
}
