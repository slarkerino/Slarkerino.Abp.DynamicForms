using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Slarkerino.Abp.DynamicForms.Projects
{
    public static class ProjectEfCoreQueryableExtensions
    {
        public static IQueryable<Project> IncludeDetails(this IQueryable<Project> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                // .Include(x => x.xxx) // TODO: AbpHelper generated
                ;
        }
    }
}