using System;
using System.Collections.Generic;

namespace PartsUnlimitedApi.Models
{
    public partial class CartItem
    {
        public int CartItemId { get; set; }
        public string CartId { get; set; } = null!;
        public int ProductId { get; set; }
        public int Count { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; } = null!;
    }
}
