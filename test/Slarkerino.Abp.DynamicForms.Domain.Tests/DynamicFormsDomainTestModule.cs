using Slarkerino.Abp.DynamicForms.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Slarkerino.Abp.DynamicForms
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(DynamicFormsEntityFrameworkCoreTestModule)
        )]
    public class DynamicFormsDomainTestModule : AbpModule
    {
        
    }
}
