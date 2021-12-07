using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Slarkerino.Abp.DynamicForms
{
    [DependsOn(
        typeof(DynamicFormsHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class DynamicFormsConsoleApiClientModule : AbpModule
    {
        
    }
}
