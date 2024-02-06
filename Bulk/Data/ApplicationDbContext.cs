using Bulk.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulk.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) 
        {
         
    }
        public DbSet<Category>Models { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            {
                modelBuilder.Entity<Category>().HasData(
                    new Category { Id=1,Name="Karthi",OrderDisplay="1"},
                     new Category { Id = 2, Name = "Bala", OrderDisplay = "5" },
                      new Category { Id = 3, Name = "Koushi", OrderDisplay = "7" },
                       new Category { Id = 4, Name = "sabeeth", OrderDisplay = "4" }
                    );
            }
        }
           
        
    }
}
