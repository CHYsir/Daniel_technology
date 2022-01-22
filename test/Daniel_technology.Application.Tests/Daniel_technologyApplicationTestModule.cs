using Volo.Abp.Modularity;

namespace Daniel_technology;

[DependsOn(
    typeof(Daniel_technologyApplicationModule),
    typeof(Daniel_technologyDomainTestModule)
    )]
public class Daniel_technologyApplicationTestModule : AbpModule
{

}
