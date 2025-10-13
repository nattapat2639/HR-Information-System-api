using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hris.Infrastructure.Persistence;
using Hris.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Hris.Infrastructure.Tests;

public class SqlPageDataRepositoryTests
{
    [Fact]
    public async Task GetOrganizationStructure_ReturnsRowsFromSeed()
    {
        await using var context = BuildContext();
        var repository = new SqlPageDataRepository(context);

        var result = await repository.GetPageAsync(
            module: "organization",
            page: "structure",
            pageNumber: 1,
            pageSize: 20,
            filters: new Dictionary<string, string>(),
            cancellationToken: default);

        Assert.NotNull(result);
        Assert.NotEmpty(result!.Rows);
    }

    [Fact]
    public async Task GetSystemSettings_ReturnsRowsFromSeed()
    {
        await using var context = BuildContext();
        var repository = new SqlPageDataRepository(context);

        var result = await repository.GetPageAsync(
            module: "settings",
            page: "system",
            pageNumber: 1,
            pageSize: 20,
            filters: new Dictionary<string, string>(),
            cancellationToken: default);

        Assert.NotNull(result);
        Assert.NotEmpty(result!.Rows);
    }

    private static HrisDbContext BuildContext()
    {
        var options = new DbContextOptionsBuilder<HrisDbContext>()
            .UseInMemoryDatabase(databaseName: $"hris-tests-{Guid.NewGuid()}")
            .Options;

        var context = new HrisDbContext(options);
        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();
        return context;
    }
}
