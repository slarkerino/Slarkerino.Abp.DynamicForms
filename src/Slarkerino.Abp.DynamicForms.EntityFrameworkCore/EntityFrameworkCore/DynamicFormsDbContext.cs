using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Slarkerino.Abp.DynamicForms.EntityFrameworkCore
{
    [ConnectionStringName(DynamicFormsDbProperties.ConnectionStringName)]
    public class DynamicFormsDbContext : AbpDbContext<DynamicFormsDbContext>, IDynamicFormsDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

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