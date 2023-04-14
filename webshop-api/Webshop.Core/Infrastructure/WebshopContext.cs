using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Webshop.Core.Features.Products;

namespace Webshop.Core.Infrastructure;

public class WebshopContext : DbContext
{
    public WebshopContext(DbContextOptions<WebshopContext> options) : base(options) { }

    public DbSet<Product> Product { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}