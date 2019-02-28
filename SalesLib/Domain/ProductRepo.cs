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
        public IProduct GetProduct(int Id)
        {
            return db.GetProduct(Id);
        }

        public List<IProduct> GetProducts()
        {
            return db.GetProducts();
        }
    }
}
