using Webshop.Core.Infrastructure;

namespace Webshop.DbSeed;

public static class DbInitializer
{
    public static async Task InitDatabase(WebshopContext context)
    {
        await context.AddRangeAsync(ProductSeeding.GenerateFakeProducts());
        await context.SaveChangesAsync();
    }
}