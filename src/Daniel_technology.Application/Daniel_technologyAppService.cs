using System;
using System.Collections.Generic;
using System.Text;
using Daniel_technology.Localization;
using Volo.Abp.Application.Services;

namespace Daniel_technology;

/* Inherit your application services from this class.
 */
public abstract class Daniel_technologyAppService : ApplicationService
{
    protected Daniel_technologyAppService()
    {
        LocalizationResource = typeof(Daniel_technologyResource);
    }
}
