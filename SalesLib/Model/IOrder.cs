﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLib.Model
{
    public interface IOrder
    {
        DateTime DeliverDate { get; }
    }
}
