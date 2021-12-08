using System;
using Volo.Abp.Domain.Repositories;

namespace Slarkerino.Abp.DynamicForms.Responses
{
    public interface IResponseRepository : IRepository<Response, Guid>
    {
    }
}