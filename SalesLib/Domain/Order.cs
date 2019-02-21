using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesLib.Model;

namespace SalesLib.Domain
{
    class Order : IOrder
    {
        public ICustomer Customer { get; }

        public DateTime DeliveryDate { get; }

        public DateTime OrderDate { get; }

        private List<IProductLineSaleItem> ProductItems { get; }

        public int OrderID { get; }

        public bool Picked { get; }

        public List<IProductLineSaleItem> GetProductLineSaleItems()
        {
            throw new NotImplementedException();
        }

        public Order(ICustomer customer, DateTime deliveryDate)
        {
            Customer = customer;
            deliveryDate = DeliveryDate;

        }

        public void AddProductLineSaleItem(IProductLineSaleItem productLineSaleItem)
        {

        }
    }
}
