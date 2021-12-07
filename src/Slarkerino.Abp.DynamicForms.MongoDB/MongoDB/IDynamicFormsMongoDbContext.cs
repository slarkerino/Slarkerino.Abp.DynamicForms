using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Slarkerino.Abp.DynamicForms.MongoDB
{
    [ConnectionStringName(DynamicFormsDbProperties.ConnectionStringName)]
    public interface IDynamicFormsMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
