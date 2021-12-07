using Volo.Abp.Modularity;

namespace Slarkerino.Abp.DynamicForms
{
    [DependsOn(
        typeof(DynamicFormsApplicationModule),
        typeof(DynamicFormsDomainTestModule)
        )]
    public class DynamicFormsApplicationTestModule : AbpModule
    {

    }
}
