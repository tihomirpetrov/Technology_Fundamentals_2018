namespace Library.Data
{
    using Microsoft.EntityFrameworkCore;
    using Library.Models;
    public class LibraryDbContext : DbContext
    {
        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=LibraryDb;Integrated security=True";
        public virtual DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

    }
}
