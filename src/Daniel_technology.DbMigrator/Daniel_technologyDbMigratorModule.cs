using Daniel_technology.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Daniel_technology.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Daniel_technologyEntityFrameworkCoreModule),
    typeof(Daniel_technologyApplicationContractsModule)
    )]
public class Daniel_technologyDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
