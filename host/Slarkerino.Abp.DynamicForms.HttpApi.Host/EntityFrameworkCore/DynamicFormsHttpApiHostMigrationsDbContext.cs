using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Slarkerino.Abp.DynamicForms.EntityFrameworkCore
{
    public class DynamicFormsHttpApiHostMigrationsDbContext : AbpDbContext<DynamicFormsHttpApiHostMigrationsDbContext>
    {
        public DynamicFormsHttpApiHostMigrationsDbContext(DbContextOptions<DynamicFormsHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureDynamicForms();
        }
    }
}
