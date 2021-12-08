using System;
using Slarkerino.Abp.DynamicForms.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Slarkerino.Abp.DynamicForms.Questions
{
    public class QuestionRepository : EfCoreRepository<IDynamicFormsDbContext, Question, Guid>, IQuestionRepository
    {
        public QuestionRepository(IDbContextProvider<IDynamicFormsDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}