using System;
using System.Collections.Generic;

namespace PartsUnlimitedApi.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
