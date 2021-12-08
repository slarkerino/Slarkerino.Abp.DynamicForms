using Volo.Abp.Data;

namespace Slarkerino.Abp.DynamicForms.Projects
{
    public interface IProject : IHasExtraProperties
    {
        string Title { get; }

        int ResponseCount { get; }

        string ProjectType { get; }

        ProjectStatus ProjectStatus { get; }
    }
}
