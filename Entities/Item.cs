﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitComrade.Models;

namespace FitComrade.Entities
{
    public class Item
    {
        public int ID { get; set; }
        public Products Products { get; set; }

        public int Quantity { get; set; }
    }
}
