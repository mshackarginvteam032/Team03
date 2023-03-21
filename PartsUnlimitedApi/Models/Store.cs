using System;
using System.Collections.Generic;

namespace PartsUnlimitedApi.Models
{
    public partial class Store
    {
        public Store()
        {
            Rainchecks = new HashSet<Raincheck>();
        }

        public int StoreId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Raincheck> Rainchecks { get; set; }
    }
}
