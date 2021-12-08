using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Slarkerino.Abp.DynamicForms.Projects;
using Slarkerino.Abp.DynamicForms.Questions;
using Slarkerino.Abp.DynamicForms.Responses;
using Slarkerino.Abp.DynamicForms.Answers;

namespace Slarkerino.Abp.DynamicForms.EntityFrameworkCore
{
    [ConnectionStringName(DynamicFormsDbProperties.ConnectionStringName)]
    public interface IDynamicFormsDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
        DbSet<Project> Projects { get; set; }
        DbSet<Question> Questions { get; set; }
        DbSet<Response> Responses { get; set; }
        DbSet<Answer> Answers { get; set; }
    }
}
