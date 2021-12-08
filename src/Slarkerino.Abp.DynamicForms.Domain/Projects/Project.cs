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

        public virtual string ProjectType { get; protected set; }

        public virtual ProjectStatus ProjectStatus { get; protected set; }

        public virtual string Tags { get; protected set; }
        
        public virtual List<Question> Questions { get; protected set; }

        public virtual Guid? TenantId { get; protected set; }



        protected Project()
        {
            ProjectStatus = ProjectStatus.Pending;
            Questions = new List<Question>();
        }

        public Project(
            Guid id,
            string title,
            int responseCount,
            string projectType,
            string tags,
            Guid? tenantId
        ) : base(id)
        {
            Title = title;
            ResponseCount = responseCount;
            ProjectType = projectType;
            ProjectStatus = ProjectStatus.Pending;
            Tags = tags;
            Questions = new List<Question>();
            TenantId = tenantId;
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

    }
}
