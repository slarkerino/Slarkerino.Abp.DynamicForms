using Slarkerino.Abp.DynamicForms.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Slarkerino.Abp.DynamicForms
{
    public abstract class DynamicFormsController : AbpController
    {
        protected DynamicFormsController()
        {
            LocalizationResource = typeof(DynamicFormsResource);
        }
    }
}
