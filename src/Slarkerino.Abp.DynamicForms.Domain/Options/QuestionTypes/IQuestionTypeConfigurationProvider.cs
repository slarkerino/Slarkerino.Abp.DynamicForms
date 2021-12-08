namespace Slarkerino.Abp.DynamicForms.Options.QuestionTypes
{
    public interface IQuestionTypeConfigurationProvider
    {
        QuestionTypeConfiguration Get(string questionTypeName);
    }
}
