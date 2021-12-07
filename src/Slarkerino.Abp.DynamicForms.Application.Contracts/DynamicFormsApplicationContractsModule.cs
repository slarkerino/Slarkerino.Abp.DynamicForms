using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Slarkerino.Abp.DynamicForms
{
    [DependsOn(
        typeof(DynamicFormsDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class DynamicFormsApplicationContractsModule : AbpModule
    {

    }
}
