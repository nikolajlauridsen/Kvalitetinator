using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesLib.Persistence;

using SalesLib.Model;

namespace SalesLib.Domain
{
    public class ProductRepo
    {
        private IDB db = FakeDB.Instance;

        void CreateProduct(string name, string description, double price, int minInStock, int id)
        {
            Product product = new Product(name, description, price, minInStock, id);
            db.CreateProduct(product);
        }

        public IProduct GetProduct(int Id)
        {
            return db.GetProduct(Id);
        }

        public List<IProduct> GetProducts()
        {
            return db.GetProducts();
        }

        public ProductRepo()
        {
            CreateProduct("Large Coconuts", "Regular coconuts except for their massive size and appeal to a young audience.", 20.0, 5, 1);
            CreateProduct("Small Cocunuts", "Smaller coconuts that appeal to a mature audience.", 5.0, 10, 2);
            CreateProduct("Cucumber", "A huge aubergine. Appeals to a broad audience", 10.0, 16, 3);
            CreateProduct("Coconut Openeer", "A tool for cutting cylindrical holes in coconuts. Maggotfree.", 25.0, 3, 4);
        }
    }
}
