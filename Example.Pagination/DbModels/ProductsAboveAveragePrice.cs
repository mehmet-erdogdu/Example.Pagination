﻿using System;
using System.Collections.Generic;

namespace Example.Pagination.DbModels
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
