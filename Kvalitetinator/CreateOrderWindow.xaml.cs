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
    /// Interaction logic for CreateOrderWindow.xaml
    /// </summary>
    public partial class CreateOrderWindow : Window
    {
        public CreateOrderWindow()
        {
            InitializeComponent();
        }

        private void CreateInactiveOrder(object sender, EventArgs e)
        {
            DateTime? deliveryDate = DeliveryDate.SelectedDate;
            string phone = PhoneEntry.Text;
            if (deliveryDate != null)
            {
                int orderID = Controller.Instance.CreateOrder(phone, (DateTime)deliveryDate);
            }
        }
    }
}
