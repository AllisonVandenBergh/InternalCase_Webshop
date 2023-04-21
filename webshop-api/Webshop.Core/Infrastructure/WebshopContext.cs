using System.Reflection;
using EntityFramework.Exceptions.SqlServer;
using Microsoft.EntityFrameworkCore;
using Webshop.Contracts.Features.V1.Products;

namespace Webshop.Core.Infrastructure;

public class WebshopContext : DbContext
{
    public WebshopContext(DbContextOptions<WebshopContext> options) : base(options) { }

    public DbSet<Product> Product { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseExceptionProcessor();
    }
}