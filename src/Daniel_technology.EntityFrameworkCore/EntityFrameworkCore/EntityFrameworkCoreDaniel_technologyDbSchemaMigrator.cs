using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Daniel_technology.Data;
using Volo.Abp.DependencyInjection;

namespace Daniel_technology.EntityFrameworkCore;

public class EntityFrameworkCoreDaniel_technologyDbSchemaMigrator
    : IDaniel_technologyDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreDaniel_technologyDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the Daniel_technologyDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Daniel_technologyDbContext>()
            .Database
            .MigrateAsync();
    }
}
