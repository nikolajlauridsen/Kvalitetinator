using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesLib.Model;

namespace SalesLib.Domain
{
    public class Customer : ICustomer
    {
        public string Name { get; }

        public string Telephone { get; }

        public string Address { get; }

        public string Zip  { get; }

        public string Town { get; }

        public int CustomerID { get; }

        public Customer(string name, string telephone, string zip, string address, string town, int customerID)
        {
            Name = name;
            Telephone = telephone;
            Address = address;
            Zip = zip;
            Town = town;
            CustomerID = customerID;
        }
    }
}
