using BookApi.ConfigureClasses;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Models.Domain
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Book> Book { get; set; }


        public DatabaseContext(DbContextOptions<DatabaseContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BookConfiguration());
        }
    }
}
