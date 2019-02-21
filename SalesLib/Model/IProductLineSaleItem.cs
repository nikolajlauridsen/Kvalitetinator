using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLib.Model
{
    public interface IProductLineSaleItem
    {
        IProduct product { get; }
        int Quantity { get; }
        double Price { get; }
        int LineID { get; }
    }
}
