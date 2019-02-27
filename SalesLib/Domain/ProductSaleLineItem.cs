using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SalesLib.Model;

namespace SalesLib.Domain
{
    public class ProductSaleLineItem : IProductLineSaleItem
    {
        public IProduct Product { get; }
        public int Quantity { get; }
        public double Price { get; private set; }
        public int LineID { get; }

        public ProductSaleLineItem(IProduct product, int quantity, double price, int lineID)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
            LineID = lineID;
        }

        public void ApplyDiscount(double amount)
        {
            Price -= amount;
        }
    }
}
