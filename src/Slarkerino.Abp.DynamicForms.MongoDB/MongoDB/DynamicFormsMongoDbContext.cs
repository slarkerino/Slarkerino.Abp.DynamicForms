using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Slarkerino.Abp.DynamicForms.MongoDB
{
    [ConnectionStringName(DynamicFormsDbProperties.ConnectionStringName)]
    public class DynamicFormsMongoDbContext : AbpMongoDbContext, IDynamicFormsMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureDynamicForms();
        }
    }
}