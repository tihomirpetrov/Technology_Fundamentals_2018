namespace CatShop.Models
{
    using Microsoft.EntityFrameworkCore;
    using CatShop.Models;

    public class CatDbContext : DbContext
    {
        public DbSet<Cat> Cats { get; set; }

        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=CatDb;Integrated Security=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
