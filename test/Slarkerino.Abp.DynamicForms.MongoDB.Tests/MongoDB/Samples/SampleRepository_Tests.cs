using Slarkerino.Abp.DynamicForms.Samples;
using Xunit;

namespace Slarkerino.Abp.DynamicForms.MongoDB.Samples
{
    [Collection(MongoTestCollection.Name)]
    public class SampleRepository_Tests : SampleRepository_Tests<DynamicFormsMongoDbTestModule>
    {
        /* Don't write custom repository tests here, instead write to
         * the base class.
         * One exception can be some specific tests related to MongoDB.
         */
    }
}
