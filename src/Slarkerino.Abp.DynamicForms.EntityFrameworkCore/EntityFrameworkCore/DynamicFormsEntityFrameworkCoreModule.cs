using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Slarkerino.Abp.DynamicForms.EntityFrameworkCore
{
    [DependsOn(
        typeof(DynamicFormsDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class DynamicFormsEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<DynamicFormsDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}