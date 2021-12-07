using Slarkerino.Abp.DynamicForms.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Slarkerino.Abp.DynamicForms.Blazor.Server.Host
{
    public abstract class DynamicFormsComponentBase : AbpComponentBase
    {
        protected DynamicFormsComponentBase()
        {
            LocalizationResource = typeof(DynamicFormsResource);
        }
    }
}
