﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM.Model
{
    public class ProductDetails
    {
        public int ProducDetailsId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int ProductStockQuantity { get; set; }
        public int CategoryId { get; set; }
    }
}
