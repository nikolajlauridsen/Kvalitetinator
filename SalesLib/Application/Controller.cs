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
        private static Controller _instance;

        public static Controller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Controller();
                }

                return _instance;
            }
        }

        OrderRepo orderRepo = new OrderRepo();
        ProductRepo productRepo = new ProductRepo();
        CustomerRepo customerRepo = new CustomerRepo();

        private Controller()
        {

        }

        public bool CreateCustomer(string name, string adress, string zip, string town, string telephone)
        {
           return customerRepo.CreateCustomer(name, adress, zip, town, telephone);
        }

        public int CreateOrder(string telephone, DateTime deliverydate)
        {
            return orderRepo.CreateOrder(customerRepo.GetCustomer(telephone), deliverydate);
        }
        public void ActivateOrder(int orderId)
        {
            orderRepo.ActivateOrder(orderId);
        }

        public void AddSaleOrderItem(IOrder order, int productId, int quantity)
        {
            order.AddProductLineSaleItem(productRepo.GetProduct(productId),quantity);

        }

        public List<IOrder> GetActiveOrders()
        {
            return orderRepo.GetActiveOrders();
        }

        public List<IOrder> GetInactiveOrders()
        {
            return orderRepo.GetInactiveOrders();
        }

        public IOrder GetInactiveOrder(int orderID)
        {
            return orderRepo.GetInactiveOrder(orderID);
        }

        public List<IProduct> GetProducts()
        {
            return productRepo.GetProducts();
        }

        public IProduct GetProduct(int id)
        {
            return productRepo.GetProduct(id);
        }
    }
}
