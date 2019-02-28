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

        public CustomerRepo()
        {
            CreateCustomer("JImbob Johnson", "Redneck Road", "7193", "Valleyville", "888-Probably-Real");
            CreateCustomer("Peter Phile", "Kindergarten Way", "8293", "Fiddleville", "28938293");
            CreateCustomer("Blue Powerranger", "Fluteville", "8473", "Voltronia", "865-Save-Our-Souls");
            CreateCustomer("Nidolaj L-Dog", "Oscar Ave.", "8931", "Pelle Pellested", "+45 16171819");
        }
    }
}
