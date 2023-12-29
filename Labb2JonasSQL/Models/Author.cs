using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb2JonasSQL.Models;

namespace Labb2JonasSQL.Models
{
    public partial class Author
    {
        public int AuthorId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime? Birthdate { get; set; }

        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
