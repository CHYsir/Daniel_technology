using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Daniel_technology.Data;

/* This is used if database provider does't define
 * IDaniel_technologyDbSchemaMigrator implementation.
 */
public class NullDaniel_technologyDbSchemaMigrator : IDaniel_technologyDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
