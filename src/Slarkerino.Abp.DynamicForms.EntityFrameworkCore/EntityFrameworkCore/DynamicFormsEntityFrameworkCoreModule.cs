using Slarkerino.Abp.DynamicForms.Answers;
using Slarkerino.Abp.DynamicForms.Responses;
using Slarkerino.Abp.DynamicForms.Questions;
using Slarkerino.Abp.DynamicForms.Projects;
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
                options.AddRepository<Project, ProjectRepository>();
                options.AddRepository<Question, QuestionRepository>();
                options.AddRepository<Response, ResponseRepository>();
                options.AddRepository<Answer, AnswerRepository>();
            });
        }
    }
}
