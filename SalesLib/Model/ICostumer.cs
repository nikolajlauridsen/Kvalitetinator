using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLib.Model
{
    interface ICostumer
    {
        string Name { get; }
        string Telephone { get; }
        string Address { get; }   
        string Zip { get; }
        string Town { get; }
        int CustomerID { get; }

    }
}
