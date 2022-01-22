using Daniel_technology.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Daniel_technology.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Daniel_technologyController : AbpControllerBase
{
    protected Daniel_technologyController()
    {
        LocalizationResource = typeof(Daniel_technologyResource);
    }
}
