using System;
using Volo.Abp.Domain.Repositories;

namespace Slarkerino.Abp.DynamicForms.Answers
{
    public interface IAnswerRepository : IRepository<Answer, Guid>
    {
    }
}