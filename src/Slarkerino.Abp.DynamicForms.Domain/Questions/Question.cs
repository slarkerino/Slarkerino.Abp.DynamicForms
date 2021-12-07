using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Data;
using Volo.Abp.Domain.Entities.Auditing;

namespace Slarkerino.Abp.DynamicForms.Questions
{
    public class Question : FullAuditedEntity<Guid>, IQuestion
    {
        public string Title { get; protected set; }

        public ExtraPropertyDictionary ExtraProperties { get; protected set; }

        public string Type { get; protected set; }

        public int MinScore { get; protected set; }

        public int MaxScore { get; protected set; }
    }
}
