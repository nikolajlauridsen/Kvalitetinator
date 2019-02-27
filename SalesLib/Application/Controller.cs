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
           return customerRepo.CreateCustomer(name, adress, zip, town, telephone);
        }

        public void CreateOrder(string telephone, DateTime deliverydate)
        {
            orderRepo.CreateOrder(customerRepo.GetCustomer(telephone), deliverydate);
        }
        public void ActivateOrder(int orderId)
        {
            orderRepo.ActivateOrder(orderId);
        }

        public void AddSaleOrderItem(IOrder order, int productId, int quantity)
        {
            order.AddProductLineSaleItem(productRepo.GetProduct(productId),quantity);

        }
    }
}
