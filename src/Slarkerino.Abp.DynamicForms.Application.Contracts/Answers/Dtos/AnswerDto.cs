using System;
using Volo.Abp.Application.Dtos;

namespace Slarkerino.Abp.DynamicForms.Answers.Dtos
{
    [Serializable]
    public class AnswerDto : ExtensibleFullAuditedEntityDto<Guid>
    {
        public Guid QuestionId { get; set; }

        public string QuestionType { get; set; }

        public string QuestionTitle { get; set; }

        public string Result { get; set; }
    }
}