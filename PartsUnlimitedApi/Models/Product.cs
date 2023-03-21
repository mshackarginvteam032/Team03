using System;
using System.Collections.Generic;

namespace PartsUnlimitedApi.Models
{
    public partial class Product
    {
        public Product()
        {
            CartItems = new HashSet<CartItem>();
            OrderDetails = new HashSet<OrderDetail>();
            Rainchecks = new HashSet<Raincheck>();
        }

        public int ProductId { get; set; }
        public string SkuNumber { get; set; } = null!;
        public int CategoryId { get; set; }
        public int RecommendationId { get; set; }
        public string Title { get; set; } = null!;
        public decimal Price { get; set; }
        public decimal SalePrice { get; set; }
        public string? ProductArtUrl { get; set; }
        public string Description { get; set; } = null!;
        public DateTime Created { get; set; }
        public string ProductDetails { get; set; } = null!;
        public int Inventory { get; set; }
        public int LeadTime { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Raincheck> Rainchecks { get; set; }
    }
}
