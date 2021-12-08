using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Data;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Slarkerino.Abp.DynamicForms.Answers
{
    public class Answer : FullAuditedEntity<Guid>, IAnswer
    {
        public virtual Guid QuestionId { get; protected set; }

        public virtual string QuestionType { get; protected set; }

        public virtual string QuestionTitle { get; protected set; }

        public virtual ExtraPropertyDictionary ExtraProperties { get; protected set; }

        public virtual string Result { get; protected set; }

        protected Answer()
        {
        }

        public Answer(
            Guid id,
            Guid questionId,
            string questionType,
            string questionTitle,
            ExtraPropertyDictionary extraProperties,
            string result
        ) : base(id)
        {
            QuestionId = questionId;
            QuestionType = questionType;
            QuestionTitle = questionTitle;
            ExtraProperties = extraProperties;
            Result = result;
        }

        public void SetResult(string result)
        {
            Result = result;
        }
    }
}
