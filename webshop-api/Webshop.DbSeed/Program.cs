using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Webshop.Core.Infrastructure;
using Webshop.DbSeed;

Console.WriteLine("Seeding the database\n");

var appSettingsPath = Path.Combine(
    Path.GetDirectoryName((Assembly.GetEntryAssembly()!).Location)!,
    "appsettings.json"
);

var config = new ConfigurationBuilder()
                .AddJsonFile(appSettingsPath, optional: true, reloadOnChange: true)
                .Build();

var connectionString = config.GetConnectionString("DefaultConnection");

var options = new DbContextOptionsBuilder<WebshopContext>()
    .UseSqlServer(connectionString)
    .Options;

using (var context = new WebshopContext(options))
{
    await DbInitializer.InitDatabase(context);
}

Console.WriteLine("Database seeded successfully.");

