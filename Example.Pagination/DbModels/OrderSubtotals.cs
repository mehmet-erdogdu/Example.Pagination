using System;
using System.Collections.Generic;

namespace Example.Pagination.DbModels
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
