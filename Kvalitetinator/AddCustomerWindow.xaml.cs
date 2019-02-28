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
    /// Interaction logic for AddCustomerWindow.xaml
    /// </summary>
    public partial class AddCustomerWindow : Window
    {
        public AddCustomerWindow()
        {
            InitializeComponent();
        }

        private void AddCustomerCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddCustomerAdd_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTxt.Text;
            string phone = PhoneTxt.Text;
            string adress = AdressTxt.Text;
            string zip = ZipTxt.Text;
            string town = TownTxt.Text;

            Controller.Instance.CreateCustomer(name, adress, zip, town, phone);
            MessageBox.Show("Customer Created");
            NameTxt.Text = "";
            PhoneTxt.Text = "";
            AdressTxt.Text = "";
            ZipTxt.Text = "";
            TownTxt.Text = "";

        }
    }
}
