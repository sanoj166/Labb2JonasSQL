using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labb2JonasSQL.Models
{
    public partial class StockBalance
    {
        [ForeignKey("Store")]
        [Column("StoreId")]
        public int StoreId { get; set; }

        public virtual Store Store { get; set; }

        [ForeignKey("Book")]
        [Column("ISBN13")]
        public string ISBN13 { get; set; }

        public virtual Book Book { get; set; }

        [Column("Quantity")]
        public int Quantity { get; set; }
    }
}
