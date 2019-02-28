using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesLib.Persistence;

namespace SalesLib.Domain
{
    public class ProductRepo
    {
        private IDB db = FakeDB.Instance;

        void CreateProduct(string name, string description, double price, int minInStock)
        {
            Product product = new Product(name, description, price, minInStock);
            db.CreateProduct(product);
        }

        public Product GetProduct(int Id)
        {
            throw new NotImplementedException();
        }

        public ProductRepo()
        {
            CreateProduct("Large Coconuts", "Regular coconuts except for their massive size and appeal to a young audience.", 20.0, 5);
            CreateProduct("Small Cocunuts", "Smaller coconuts that appeal to a mature audience.", 5.0, 10);
            CreateProduct("Cucumber", "A huge aubergine. Appeals to a broad audience", 10.0, 16);
            CreateProduct("Coconut Openeer", "A tool for cutting cylindrical holes in coconuts. Maggotfree.", 25.0, 3);
        }
    }
}
