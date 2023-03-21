using System;
using System.Collections.Generic;

namespace PartsUnlimitedApi.Models
{
    public partial class Raincheck
    {
        public int RaincheckId { get; set; }
        public string? Name { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public double SalePrice { get; set; }
        public int StoreId { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual Store Store { get; set; } = null!;
    }
}
