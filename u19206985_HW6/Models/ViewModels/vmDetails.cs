﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19206985_HW6.Models.ViewModels
{
    public class vmDetails
    {
       
        public string product_name { get; set; }
        public short model_year { get; set; }
        public decimal list_price { get; set; }
        public string brand_name { get; set; }
        public string category_name { get; set; }

        public List<vmStoreQuantity> storeQuantities { get; set; }
    }
}