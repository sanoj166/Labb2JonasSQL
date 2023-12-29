using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Labb2JonasSQL.Models;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Labb2JonasSQL.Data
{
    public class BookstoreContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<StockBalance> StockBalances { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public List<StockBalance> GetStockBalanceInfo()
        {
            return StockBalances
                .Include(sb => sb.Store)
                .Include(sb => sb.Book)
                .ToList();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StockBalance>()
                .HasKey(sb => new { sb.StoreId, sb.ISBN13 });

            modelBuilder.Entity<StockBalance>().ToTable("StockBalance");
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Labb1JonasHaggu;Integrated Security=True");
        }
    }
}






