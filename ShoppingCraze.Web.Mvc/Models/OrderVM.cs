﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCraze.Web.Mvc.Models
{
    public class OrderVM
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}