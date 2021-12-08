using System;
using Volo.Abp.Application.Dtos;

namespace Slarkerino.Abp.DynamicForms.Questions.Dtos
{
    [Serializable]
    public class QuestionDto : ExtensibleFullAuditedEntityDto<Guid>
    {
        public string Title { get; set; }

        public string QuestionType { get; set; }

        public int MinScore { get; set; }

        public int MaxScore { get; set; }
    }
}