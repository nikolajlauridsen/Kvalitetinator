﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using SalesLib.Application;
using SalesLib.Model;

namespace Kvalitetinator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (IOrder order in Controller.Instance.GetActiveOrders())
            {
                OrderList.Items.Add(new OrderItem
                {
                    OrderID = order.OrderID.ToString(),
                    Customer = order.Customer.Name,
                    Delivery = order.DeliveryDate.ToString()
                });
            }

            ActiveRadio.Checked += LoadActiveOrders;
            InactiveRadio.Checked += LoadInactiveOrders;
            AddOrderBtn.Click += ShowCreateOrder;

            ActiveRadio.IsChecked = true;

        }


        private void ShowCreateOrder(object sender, EventArgs e)
        {
            CreateOrderWindow orderWindow = new CreateOrderWindow();
            orderWindow.Show();
        }

        private void LoadActiveOrders(object sender, EventArgs e)
        {
            OrderList.Items.Clear();
            foreach (IOrder order in Controller.Instance.GetActiveOrders()) {
                OrderList.Items.Add(new OrderItem {
                    OrderID = order.OrderID.ToString(),
                    Customer = order.Customer.Name,
                    Delivery = order.DeliveryDate.ToString()
                });
            }
        }

        private void LoadInactiveOrders(object sender, EventArgs e)
        {
            OrderList.Items.Clear();
            foreach (IOrder order in Controller.Instance.GetInactiveOrders()) {
                OrderList.Items.Add(new OrderItem {
                    OrderID = order.OrderID.ToString(),
                    Customer = order.Customer.Name,
                    Delivery = order.DeliveryDate.ToString()
                });
            }
        }
    }

    public class OrderItem
    {
        public string OrderID;
        public string Customer;
        public string Delivery;
    }
}
