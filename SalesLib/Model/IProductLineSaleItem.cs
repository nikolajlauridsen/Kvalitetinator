using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLib.Model
{
    public interface IProductLineSaleItem
    {
        IProduct Product { get; }
        int Quantity { get; }
        double Price { get; }
        int LineID { get; }

        void ApplyDiscount(double amount);
    }
}
