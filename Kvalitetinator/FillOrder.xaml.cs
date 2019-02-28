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
        private EventHandler _refresh;

        public FillOrder(IOrder order, EventHandler refreshHandler)
        {
            InitializeComponent();
            _refresh = refreshHandler;
            _order = order;

            DeliveryDateLabel.Content = _order.DeliveryDate.ToShortDateString();
            OrderDateLabel.Content = _order.OrderDate.ToShortDateString();
            CustomerLabel.Content = _order.Customer.Name;

            foreach (IProduct product in Controller.Instance.GetProducts())
            {
                AvailableProducts.Items.Add(product);
            }

            AddProductBtn.Click += AddProduct;
            ActivateBtn.Click += ActivateOrder;
        }

        public void AddProduct(object sender, EventArgs e)
        {
            dynamic item = AvailableProducts.SelectedItem as dynamic;
            int productID = item.ProductID;
            int quantity = int.Parse(Quantity.Text);
            Controller.Instance.AddSaleOrderItem(_order, productID, quantity);

            IProduct selectedProduct = Controller.Instance.GetProduct(productID);
            ProductLines.Items.Add(new ProductMock(selectedProduct.Name, quantity));
        }

        public void ActivateOrder(object sender, EventArgs e)
        {
            Controller.Instance.ActivateOrder(_order.OrderID);
            _refresh(this, null);
            this.Close();
        }

        private class ProductMock
        {
            public string Name { get; }
            public string Quantity { get; }

            public ProductMock(string name, int quantity)
            {
                Name = name;
                Quantity = quantity.ToString();
            }
        }
    }
}
