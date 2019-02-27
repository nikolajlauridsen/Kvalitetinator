using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesLib.Model;
using SalesLib.Persistence;

namespace SalesLib.Domain
{
    public class CustomerRepo
    {
        private IDB db = FakeDB.Instance;

        public bool CreateCustomer(string name, string address, string zip, string town, string telephone)
        {
            if (db.GetCustomer(telephone) == null)
            {
                ICustomer customer = new Customer(name, telephone, zip, address, town, -1);
                int customerID = db.CreateCustomer(customer);
                customer.CustomerID = customerID;
                return true;
            }

            return false;
        }

        public ICustomer GetCustomer(string telephone)
        {
            return db.GetCustomer(telephone);
        }
    }
}
