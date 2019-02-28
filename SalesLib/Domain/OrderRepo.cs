using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesLib.Model;
using SalesLib.Persistence;

namespace SalesLib.Domain
{
    public class OrderRepo
    {
        private IDB db = FakeDB.Instance;

        public int CreateOrder(ICustomer customer, DateTime deliveryDate)
        {
            IOrder order = new Order(customer, deliveryDate);
            int id = db.CreateOrder(order);
            order.OrderID = id;
            return id;
        }

        public void ActivateOrder(int orderID)
        {
            db.ActivateOrder(orderID);
        }

        public List<IOrder> GetActiveOrders()
        {
            return db.GetActiveOrders();
        }
 
        public List<IOrder> GetInactiveOrders()
        {
            return db.GetInactiveOrders();
        }
        public IOrder GetInactiveOrder(int id)
        {
            return db.GetInactiveOrder(id);
        }
    }
}
