﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB_MVC.Rentals
{
    public class AdjustPrice
    {
        public decimal NewPrice { get; set; }
        public string Reason { get; set; }
    }
}
