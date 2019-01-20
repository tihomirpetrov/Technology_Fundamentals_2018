using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using BandRegister.Models;

namespace BandRegister.Data
{
    public class BandDbContext : DbContext
    {
        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=BandDb;Integrated security=True";
        public virtual DbSet<Band> Bands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
