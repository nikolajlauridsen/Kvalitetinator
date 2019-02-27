using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesLib.Model;

namespace SalesLib.Domain
{
    public class Order : IOrder
    {
        public ICustomer Customer { get; }

        public DateTime DeliveryDate { get; }

        public DateTime OrderDate { get; }

        private List<IProductLineSaleItem> ProductItems { get; }

        public int OrderID { get; }

        public bool Picked { get; }

        public Order(ICustomer customer, DateTime deliveryDate, int orderID)
        {
            Customer = customer;
            DeliveryDate = deliveryDate;
            OrderID = orderID;

        }

        public List<IProductLineSaleItem> GetProductLineSaleItems()
        {
            List<IProductLineSaleItem> items = new List<IProductLineSaleItem>();

            items = ProductItems.ToList();

            return items;
        }

        public void AddProductLineSaleItem(IProductLineSaleItem productLineSaleItem)
        {
            ProductItems.Add(productLineSaleItem);
        }
    }
}
