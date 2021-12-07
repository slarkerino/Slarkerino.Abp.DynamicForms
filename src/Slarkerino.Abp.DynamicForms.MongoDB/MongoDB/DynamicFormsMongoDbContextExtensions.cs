using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Slarkerino.Abp.DynamicForms.MongoDB
{
    public static class DynamicFormsMongoDbContextExtensions
    {
        public static void ConfigureDynamicForms(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new DynamicFormsMongoModelBuilderConfigurationOptions(
                DynamicFormsDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}