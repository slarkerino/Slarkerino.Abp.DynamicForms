using Slarkerino.Abp.DynamicForms.Localization;
using Volo.Abp.Application.Services;

namespace Slarkerino.Abp.DynamicForms
{
    public abstract class DynamicFormsAppService : ApplicationService
    {
        protected DynamicFormsAppService()
        {
            LocalizationResource = typeof(DynamicFormsResource);
            ObjectMapperContext = typeof(DynamicFormsApplicationModule);
        }
    }
}
