using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Slarkerino.Abp.DynamicForms.EntityFrameworkCore
{
    [ConnectionStringName(DynamicFormsDbProperties.ConnectionStringName)]
    public interface IDynamicFormsDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}