// File to provide more information to EF core on how to create the TravelApiContext

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TravelApi.Models;
public class TravelApiContextFactory : IDesignTimeDbContextFactory<TravelApiContext>
{
    // Error CS0738 'TravelApiContextFactory' does not implement interface member 'IDesignTimeDbContextFactory<TravelApiContext>.CreateDbContext(string[])'. 'TravelApiContextFactory.CreateDbContext(string[])' cannot implement 'IDesignTimeDbContextFactory<TravelApiContext>.CreateDbContext(string[])' because it does not have the matching return type of 'TravelApiContext
    // Solution: the Method CreateDbContext expects a return type of TravelApiContext since we already configured it to use such object while inheriting from it...To solve the error, the method CreateDbContext returns a TravelApiContext not a TravelApiContextFactory
    public TravelApiContext CreateDbContext(string[] args)
    {
        // Create a new configuration builder and set path to appsettings.json
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        // Get the connection string from the configuration
        var optionsBuilder = new DbContextOptionsBuilder<TravelApiContext>();
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        // Use MySql or SQL server depending on your Setup
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

        return new TravelApiContext(optionsBuilder.Options);

    }
}


// Since the error persisted, I added a Design time factory for my DbContext
// This factory ensures EF Core can instantiate your DbContext when running design-time commands like dotnet ef migrations add.
// The Design-Time Factory (IDesignTimeDbContextFactory) is a handy tool for cases like this where EF Core needs a bit more guidance on how to create an instance of your DbContext at design time, especially when using dotnet ef commands.

