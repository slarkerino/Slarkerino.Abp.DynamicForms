using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Slarkerino.Abp.DynamicForms.Responses
{
    public class Response : FullAuditedAggregateRoot<Guid>, IResponse, IMultiTenant
    {
        public int Sequence => throw new NotImplementedException();

        public DateTime StartTime => throw new NotImplementedException();

        public DateTime EndTime => throw new NotImplementedException();

        public string IPAddress => throw new NotImplementedException();

        public string Source => throw new NotImplementedException();

        public Guid? TenantId => throw new NotImplementedException();
    }
}
