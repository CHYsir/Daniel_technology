using System.Threading.Tasks;

namespace Daniel_technology.Data;

public interface IDaniel_technologyDbSchemaMigrator
{
    Task MigrateAsync();
}
