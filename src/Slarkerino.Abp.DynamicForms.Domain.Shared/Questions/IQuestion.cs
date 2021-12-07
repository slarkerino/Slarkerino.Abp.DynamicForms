using Volo.Abp.Data;

namespace Slarkerino.Abp.DynamicForms.Questions
{
    public interface IQuestion : IHasExtraProperties
    {
        string Title { get; }

        string Type { get; }

        int MinScore { get; }

        int MaxScore { get; }
    }
}
