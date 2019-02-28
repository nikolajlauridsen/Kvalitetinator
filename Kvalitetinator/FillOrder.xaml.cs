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
using System.Windows.Shapes;

using SalesLib.Application;
using SalesLib.Model;

namespace Kvalitetinator
{
    /// <summary>
    /// Interaction logic for FillOrder.xaml
    /// </summary>
    public partial class FillOrder : Window
    {
        private IOrder _order;

        public FillOrder(IOrder order)
        {
            InitializeComponent();

            _order = order;

            DeliveryDateLabel.Content = _order.DeliveryDate.ToShortDateString();
            OrderDateLabel.Content = _order.OrderDate.ToShortDateString();
            CustomerLabel.Content = _order.Customer.Name;

            foreach (IProduct product in Controller.Instance.GetProducts())
            {
                AvailableProducts.Items.Add(product);
            }
        }
    }
}
