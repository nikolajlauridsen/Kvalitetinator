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
        private IDB db = new FakeDB();
        public Product GetProduct(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
