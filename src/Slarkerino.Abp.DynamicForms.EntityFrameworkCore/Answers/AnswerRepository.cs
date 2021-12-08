using System;
using Slarkerino.Abp.DynamicForms.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Slarkerino.Abp.DynamicForms.Answers
{
    public class AnswerRepository : EfCoreRepository<IDynamicFormsDbContext, Answer, Guid>, IAnswerRepository
    {
        public AnswerRepository(IDbContextProvider<IDynamicFormsDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}