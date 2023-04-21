using Webshop.Core.Infrastructure;
using Webshop.Core.Utilities;

namespace Webshop.DbSeed;

public static class DbInitializer
{
    public static async Task InitDatabase(WebshopContext context)
    {
        await context.AddRangeAsync(ProductSeeding.GenerateFakeProducts);
        await context.SaveChangesAsync();
    }
}