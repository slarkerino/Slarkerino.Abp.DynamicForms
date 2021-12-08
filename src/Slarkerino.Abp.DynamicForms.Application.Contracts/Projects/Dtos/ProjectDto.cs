using Slarkerino.Abp.DynamicForms.Questions.Dtos;
using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Slarkerino.Abp.DynamicForms.Projects.Dtos
{
    [Serializable]
    public class ProjectDto : ExtensibleFullAuditedEntityDto<Guid>
    {
        public string Title { get; set; }

        public int ResponseCount { get; set; }

        public string ProjectType { get; set; }

        public ProjectStatus ProjectStatus { get; set; }

        public string Tags { get; set; }

        public List<QuestionDto> Questions { get; set; }

    }
}