using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public class InheritanceContext : DbContext
    {
        public InheritanceContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=InventoryManager;Trusted_Connection=True;");
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<Book> Books { get; set; }
    }
}
