using Daniel_technology.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Daniel_technology;

[DependsOn(
    typeof(Daniel_technologyEntityFrameworkCoreTestModule)
    )]
public class Daniel_technologyDomainTestModule : AbpModule
{

}
