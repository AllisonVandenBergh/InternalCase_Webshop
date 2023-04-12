using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using Domain.Entities;
using Infrastructure.Configurations;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class WebshopContext : DbContext
    {
        public WebshopContext(DbContextOptions<WebshopContext> options) : base(options) { }

        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Product>()
                .HasData(DatabaseSeed.GenerateFakeProducts());
        }
    }
}

