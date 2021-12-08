using Slarkerino.Abp.DynamicForms.Answers;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Slarkerino.Abp.DynamicForms.Responses
{
    public class Response : FullAuditedAggregateRoot<Guid>, IResponse, IMultiTenant
    {
        public virtual int Sequence { get; protected set; }

        public virtual DateTime StartTime { get; protected set; }

        public virtual DateTime EndTime { get; protected set; }

        public virtual string Source { get; protected set; }

        public virtual Guid? TenantId { get; protected set; }

        public virtual Guid ProjectId { get; protected set; }

        public virtual ICollection<Answer> Answers { get; protected set; }


    }
}
