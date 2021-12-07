using Slarkerino.Abp.DynamicForms.Questions;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Slarkerino.Abp.DynamicForms.Projects
{
    public class Project : FullAuditedAggregateRoot<Guid>, IProject, IMultiTenant
    {
        public virtual string Title { get; protected set; }

        public virtual int ResponseCount { get; protected set; }

        public virtual string Type { get; protected set; }

        public virtual ProjectStatus ProjectStatus { get; protected set; }

        public virtual string Tags { get; protected set; }
        
        public virtual ICollection<Question> Questions { get; protected set; }

        public virtual Guid? TenantId { get; protected set; }


    }
}
