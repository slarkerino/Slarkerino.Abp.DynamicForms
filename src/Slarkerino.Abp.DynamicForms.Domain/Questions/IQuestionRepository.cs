using System;
using Volo.Abp.Domain.Repositories;

namespace Slarkerino.Abp.DynamicForms.Questions
{
    public interface IQuestionRepository : IRepository<Question, Guid>
    {
    }
}