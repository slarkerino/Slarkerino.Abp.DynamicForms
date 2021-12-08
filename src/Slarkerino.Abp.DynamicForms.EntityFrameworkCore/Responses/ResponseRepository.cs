using System;
using Slarkerino.Abp.DynamicForms.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Slarkerino.Abp.DynamicForms.Responses
{
    public class ResponseRepository : EfCoreRepository<IDynamicFormsDbContext, Response, Guid>, IResponseRepository
    {
        public ResponseRepository(IDbContextProvider<IDynamicFormsDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}