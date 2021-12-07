using Localization.Resources.AbpUi;
using Slarkerino.Abp.DynamicForms.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Slarkerino.Abp.DynamicForms
{
    [DependsOn(
        typeof(DynamicFormsApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class DynamicFormsHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(DynamicFormsHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<DynamicFormsResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
