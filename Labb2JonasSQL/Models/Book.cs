using Labb2JonasSQL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2JonasSQL.Models
{
    public partial class Book
    {
        [Key]
        public string ISBN13 { get; set; } = null!; 

        public string? Title { get; set; }

        public string? Language { get; set; }

        public decimal? Price { get; set; }       

        public int? AuthorID { get; set; }

        public DateTime? PublicationDate { get; set; }

        public virtual Author? Author { get; set; }

        public virtual ICollection<StockBalance> StockBalances { get; set; } = new List<StockBalance>();

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
