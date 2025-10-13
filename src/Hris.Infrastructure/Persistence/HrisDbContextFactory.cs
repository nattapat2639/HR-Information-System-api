using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Hris.Infrastructure.Persistence;

public class HrisDbContextFactory : IDesignTimeDbContextFactory<HrisDbContext>
{
    public HrisDbContext CreateDbContext(string[] args)
    {
        var connectionString = Environment.GetEnvironmentVariable("HRIS_CONNECTION_STRING")
            ?? "Host=localhost;Port=5432;Database=hris_information;Username=postgres;Password=5139";

        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        var optionsBuilder = new DbContextOptionsBuilder<HrisDbContext>();
        optionsBuilder.UseNpgsql(connectionString);

        return new HrisDbContext(optionsBuilder.Options);
    }
}
