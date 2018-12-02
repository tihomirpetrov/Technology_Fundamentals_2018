namespace Library.Data
{
    using Microsoft.EntityFrameworkCore;
    using Library.Models;
    public class LibraryDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=LibraryDb;Integrated Security=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}