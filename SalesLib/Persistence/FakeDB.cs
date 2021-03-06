﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesLib.Domain;
using SalesLib.Model;

namespace SalesLib.Persistence
{
    public class FakeDB : IDB
    {
        private static IDB _instance;
        public static IDB Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FakeDB();
                }

                return _instance;
            }
        }

        private FakeDB()
        {
            Customer c1 = new Customer("Nikolaj", "88888888", "7000", "Omegalul 3", "Fredericia", 1);
            customers.Add(c1);
        }

        private readonly List<IOrder> activeOrders = new List<IOrder>();
        private readonly List<IOrder> inactiveOrders = new List<IOrder>();
        private readonly List<ICustomer> customers = new List<ICustomer>();
        private readonly List<IProduct> products = new List<IProduct>();

        IDB IDB.Instance => Instance;

        public int CreateCustomer(ICustomer customer)
        {
            int id = customers[customers.Count - 1].CustomerID+1;
            ICustomer _customer = new Customer(customer.Name, customer.Telephone, customer.Zip, customer.Address, customer.Town, id);
            customers.Add(_customer);
            return id;
        }

        public void CreateProduct(IProduct product)
        {
            products.Add(product);
        }

        public int CreateOrder(IOrder order)
        {
            int id = inactiveOrders.Count;
            IOrder _order = new Order(order.Customer, order.DeliveryDate, id);
            inactiveOrders.Add(_order);
            return id;
        }

        public void ActivateOrder(int orderID)
        {
            IOrder targetOrder = GetInactiveOrder(orderID);
            inactiveOrders.Remove(targetOrder);
            targetOrder.OrderID = activeOrders.Count;
            activeOrders.Add(targetOrder);
        }

        public IOrder GetActiveOrder(int orderID)
        {
            foreach (IOrder order in activeOrders)
            {
                if (order.OrderID == orderID)
                {
                    return order;
                }
            }
            return null;
        }

        public List<IOrder> GetActiveOrders()
        {
            return activeOrders;
        }

        public IOrder GetInactiveOrder(int orderID)
        {
            foreach (IOrder order in inactiveOrders) {
                if (order.OrderID == orderID) {
                    return order;
                }
            }
            return null;
        }

        public List<IOrder> GetInactiveOrders()
        {
            return inactiveOrders;
        }

        public ICustomer GetCustomer(string telephone)
        {
            foreach (ICustomer customer in customers) {
                if (customer.Telephone.Equals(telephone)) {
                    return customer;
                }
            }

            return null;
        }

        public IProduct GetProduct(int productID)
        {
            foreach (IProduct product in products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }

            return null;
        }

        public List<IProduct> GetProducts()
        {
            return products;
        }

        public ICustomer GetCustomer(int customerID)
        {
            foreach (ICustomer customer in customers)
            {
                if (customer.CustomerID == customerID)
                {
                    return customer;
                }
            }

            return null;
        }

        public void AddSaleLineItem(IOrder order, IProductLineSaleItem lineSaleItem)
        {
            
        }

       
    }

}
