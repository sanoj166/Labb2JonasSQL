using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2JonasSQL.Models
{
    public partial class Store
    {
        public int StoreId { get; set; }

        public string StoreName { get; set; }

        public string Address { get; set; }

        public string PostalCode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public virtual ICollection<StockBalance> StockBalances { get; set; } = new List<StockBalance>();
    }
}
