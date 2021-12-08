using System;
using Volo.Abp.ObjectExtending;

namespace Slarkerino.Abp.DynamicForms.Answers.Dtos
{
    [Serializable]
    public class AnswerUpdateDto : ExtensibleObject
    {
        public Guid QuestionId { get; set; }

        public string QuestionType { get; set; }

        public string QuestionTitle { get; set; }
    }
}