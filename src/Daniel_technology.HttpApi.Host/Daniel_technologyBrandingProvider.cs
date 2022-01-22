using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Daniel_technology;

[Dependency(ReplaceServices = true)]
public class Daniel_technologyBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Daniel_technology";
}
