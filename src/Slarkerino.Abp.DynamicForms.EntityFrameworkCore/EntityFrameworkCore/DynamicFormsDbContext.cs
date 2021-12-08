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
    public class DynamicFormsDbContext : AbpDbContext<DynamicFormsDbContext>, IDynamicFormsDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Project> Projects { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<Answer> Answers { get; set; }

        public DynamicFormsDbContext(DbContextOptions<DynamicFormsDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureDynamicForms();
        }
    }
}
