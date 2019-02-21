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
        DateTime DeliverDate { get; }
        DateTime OrderDate { get; }

        // TODO: Add List<ProductSaleLineItem>

        int OrderID { get; }
        Boolean Picked { get; }
    }
}
