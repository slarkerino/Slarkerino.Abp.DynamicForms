using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Data;
using Volo.Abp.Domain.Entities.Auditing;

namespace Slarkerino.Abp.DynamicForms.Questions
{
    public class Question : FullAuditedEntity<Guid>, IQuestion
    {
        public virtual string Title { get; protected set; }

        public virtual ExtraPropertyDictionary ExtraProperties { get; protected set; }

        public virtual string QuestionType { get; protected set; }

        public virtual int MinScore { get; protected set; }

        public virtual int MaxScore { get; protected set; }

        protected Question()
        {
        }

        public Question(
            Guid id,
            string title,
            ExtraPropertyDictionary extraProperties,
            string questionType,
            int minScore,
            int maxScore
        ) : base(id)
        {
            Title = title;
            ExtraProperties = extraProperties;
            QuestionType = questionType;
            MinScore = minScore;
            MaxScore = maxScore;
        }
    }
}
