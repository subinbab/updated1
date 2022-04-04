﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.Product
{
    public class ProductListViewModel
    {
        [DisplayName("Brand")]
        public string productBrand { get; set; }
        [DisplayName("Model Name")]
        public string model { get; set; }
        [DisplayName("Quantity")]
        public int quantity { get; set; }
        [DisplayName("Price")]
        public int price { get; set; }
    }
}
