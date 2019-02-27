using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesLib.Model;

namespace SalesLib.Persistence
{
    public interface IDB
    {
        IDB Instance { get;}
        int CreateCustomer(ICustomer customer);
        int CreateOrder(IOrder order);
        void CreateProduct(IProduct product);

        void ActivateOrder(int orderID);

        IOrder GetActiveOrder(int orderID);
        List<IOrder> GetActiveOrders();
        IOrder GetInactiveOrder(int orderID);
        List<IOrder> GetInactiveOrders();
        ICustomer GetCustomer(int customerID);
        ICustomer GetCustomer(string telephone);

        void AddSaleLineItem(IOrder order, IProductLineSaleItem saleLineItem);

    }
}
