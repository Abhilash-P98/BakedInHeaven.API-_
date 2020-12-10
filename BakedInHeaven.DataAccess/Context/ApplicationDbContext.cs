using System;
using System.Collections.Generic;
using System.Text;
using BakedInHeaven.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BakedInHeaven.DataAccess.Context
{
    public  class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        public DbSet<User> User { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=bakerydb;Username=postgres;Password=exp@123");
    }
}
