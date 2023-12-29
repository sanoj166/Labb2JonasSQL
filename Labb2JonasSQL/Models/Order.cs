using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2JonasSQL.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public string ISBN13 { get; set; }

        public virtual Book Book { get; set; }

        public int StoreId { get; set; }

        public virtual Store Store { get; set; }

        public decimal Price { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
