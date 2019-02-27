using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLib.Model
{
    public interface IOrder
    {
        ICustomer Customer { get; }
        DateTime DeliveryDate { get; }
        DateTime OrderDate { get; }

        int OrderID { get; set; }
        Boolean Picked { get; }

        List<IProductLineSaleItem> GetProductLineSaleItems();
    }
}
