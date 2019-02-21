using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLib.Model
{
    interface IProduct
    {
        string Name { get; }
        string Description { get; }
        double Price { get; }
        int MinInStock { get; }
    }
}
