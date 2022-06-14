using Microsoft.EntityFrameworkCore;

namespace Restaurant.Models.ORM
{
    public class ResContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = localhost\SQLEXPRESS;Database=Restaurant;Trusted_Connection=True;");
        }

        public DbSet<Restaurant1> Restaurants { get; set; }

    }
}
