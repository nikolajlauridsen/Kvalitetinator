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

        public int OrderID { get; set; }

        public bool Picked { get; }

        public Order(ICustomer customer, DateTime deliveryDate, int orderID)
        {
            ProductItems = new List<IProductLineSaleItem>();
            Customer = customer;
            DeliveryDate = deliveryDate;
            OrderDate = DateTime.Now;
            OrderID = orderID;
        }

        public Order(ICustomer customer, DateTime deliveryDate) : this(customer, deliveryDate, -1)
        {
        }

        public List<IProductLineSaleItem> GetProductLineSaleItems()
        {
            List<IProductLineSaleItem> items = new List<IProductLineSaleItem>();

            items = ProductItems.ToList();

            return items;
        }

        public void AddProductLineSaleItem(IProduct product, int quantity)
        {
            IProductLineSaleItem item = new ProductSaleLineItem(product, quantity, 1);
            ProductItems.Add(item);
        }
    }
}
