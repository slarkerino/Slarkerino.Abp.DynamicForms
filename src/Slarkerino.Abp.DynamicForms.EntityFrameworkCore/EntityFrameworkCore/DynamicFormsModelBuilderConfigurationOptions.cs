using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Slarkerino.Abp.DynamicForms.EntityFrameworkCore
{
    public class DynamicFormsModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public DynamicFormsModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}