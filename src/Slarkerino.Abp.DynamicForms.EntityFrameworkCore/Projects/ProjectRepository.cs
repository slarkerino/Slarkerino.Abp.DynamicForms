using System;
using Slarkerino.Abp.DynamicForms.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Slarkerino.Abp.DynamicForms.Projects
{
    public class ProjectRepository : EfCoreRepository<IDynamicFormsDbContext, Project, Guid>, IProjectRepository
    {
        public ProjectRepository(IDbContextProvider<IDynamicFormsDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}