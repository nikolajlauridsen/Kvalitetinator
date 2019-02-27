using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLib.Application
{
    public class Controller
    {
        
        public bool CreateCustomer(string name, string adress, string zip, string town, string telephone)
        {
            bool customerCreated = true;
            return customerCreated;
        }

        public void CreateOrder(string telephone, DateTime deliverydate)
        {

        }
    }
}
