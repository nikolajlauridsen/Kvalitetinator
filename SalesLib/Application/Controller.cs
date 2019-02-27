using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesLib.Model;
using SalesLib.Domain;

namespace SalesLib.Application
{
    public class Controller
    {
        OrderRepo orderRepo = new OrderRepo();
        ProductRepo productRepo = new ProductRepo();
        CustomerRepo customerRepo = new CustomerRepo();

        public bool CreateCustomer(string name, string adress, string zip, string town, string telephone)
        {
            bool customerCreated = true;    // remove
            return customerCreated;         // remove
        }

        public void CreateOrder(string telephone, DateTime deliverydate)
        {

        }
        public void ActivateOrder(int orderId)
        {

        }

        public void AddSaleOrderItem(IOrder order, int productId, int quantity)
        {

        }
    }
}
