using System;
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
using SalesLib.Domain;
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
                OrderList.Items.Add(new OrderItem(order.OrderID, order.Customer.Name, order.DeliveryDate.ToShortDateString()));
            }

            ActiveRadio.Checked += LoadActiveOrders;
            InactiveRadio.Checked += LoadInactiveOrders;
            AddOrderBtn.Click += ShowCreateOrder;

            ActiveRadio.IsChecked = true;

        }


        private void ShowCreateOrder(object sender, EventArgs e)
        {
            CreateOrderWindow orderWindow = new CreateOrderWindow(RefreshList);
            orderWindow.Show();
        }

        private void LoadActiveOrders(object sender, EventArgs e)
        {
            OrderList.Items.Clear();
            foreach (IOrder order in Controller.Instance.GetActiveOrders()) {
                OrderList.Items.Add(new OrderItem(order.OrderID, order.Customer.Name, order.DeliveryDate.ToShortDateString()));
            }
        }

        private void LoadInactiveOrders(object sender, EventArgs e)
        {
            OrderList.Items.Clear();
            foreach (IOrder order in Controller.Instance.GetInactiveOrders()) {
                OrderList.Items.Add(new OrderItem(order.OrderID, order.Customer.Name, order.DeliveryDate.ToShortDateString()));
            }
        }

        private void RefreshList(object sender, EventArgs e)
        {
            if (ActiveRadio.IsChecked != null && (bool)ActiveRadio.IsChecked)
            {
                LoadActiveOrders(null, null);
            }
            else
            {
                LoadInactiveOrders(null, null);
            }
        }

        private void AddCustomerBtn_Click(object sender, RoutedEventArgs e)
        {
            AddCustomerWindow addCustomer = new AddCustomerWindow();
            addCustomer.Show();
        }
    }

    public class OrderItem
    {
        public string OrderID { get; }
        public string Customer { get; }
        public string Delivery { get; }

        public OrderItem(int orderID, string customer, string delivery)
        {
            OrderID = orderID.ToString();
            Customer = customer;
            Delivery = delivery;
        }
    }
}
