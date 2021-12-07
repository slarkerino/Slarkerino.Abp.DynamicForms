using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Slarkerino.Abp.DynamicForms
{
    [DependsOn(
        typeof(DynamicFormsApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class DynamicFormsHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "DynamicForms";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(DynamicFormsApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
