using System;
using Volo.Abp.Domain.Repositories;

namespace Slarkerino.Abp.DynamicForms.Projects
{
    public interface IProjectRepository : IRepository<Project, Guid>
    {
    }
}