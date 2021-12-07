using Volo.Abp.Data;

namespace Slarkerino.Abp.DynamicForms.Projects
{
    public interface IProject : IHasExtraProperties
    {
        string Title { get; }

        int ResponseCount { get; }

        string Type { get; }

        ProjectStatus ProjectStatus { get; }
    }
}
