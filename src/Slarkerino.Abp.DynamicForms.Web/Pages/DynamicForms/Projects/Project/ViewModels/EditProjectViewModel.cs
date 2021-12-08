using System;

using System.ComponentModel.DataAnnotations;

namespace Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Projects.Project.ViewModels
{
    public class EditProjectViewModel
    {
        [Display(Name = "ProjectTitle")]
        public string Title { get; set; }

        [Display(Name = "ProjectResponseCount")]
        public int ResponseCount { get; set; }

        [Display(Name = "ProjectProjectType")]
        public string ProjectType { get; set; }

        [Display(Name = "ProjectProjectStatus")]
        public ProjectStatus ProjectStatus { get; set; }

        [Display(Name = "ProjectTags")]
        public string Tags { get; set; }

        [Display(Name = "ProjectQuestions")]
        public ICollection<Question> Questions { get; set; }

    }
}