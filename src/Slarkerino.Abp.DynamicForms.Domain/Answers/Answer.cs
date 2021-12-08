using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Data;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Slarkerino.Abp.DynamicForms.Answers
{
    public class Answer : FullAuditedEntity<Guid>, IAnswer, IMultiTenant
    {
        public virtual Guid QuestionId { get; protected set; }

        public virtual string QuestionType { get; protected set; }

        public virtual string QuestionTitle { get; protected set; }

        public virtual ExtraPropertyDictionary ExtraProperties { get; protected set; }

        public virtual Guid? TenantId { get; protected set; }

        public virtual string Result { get; protected set; }
    }
}
