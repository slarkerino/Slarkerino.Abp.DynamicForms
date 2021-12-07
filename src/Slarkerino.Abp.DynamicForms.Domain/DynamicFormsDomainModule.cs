using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Slarkerino.Abp.DynamicForms
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(DynamicFormsDomainSharedModule)
    )]
    public class DynamicFormsDomainModule : AbpModule
    {

    }
}
