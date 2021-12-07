using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Slarkerino.Abp.DynamicForms.MongoDB
{
    public class DynamicFormsMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public DynamicFormsMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}