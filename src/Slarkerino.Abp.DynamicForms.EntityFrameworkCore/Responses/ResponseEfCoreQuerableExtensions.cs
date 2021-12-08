using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Slarkerino.Abp.DynamicForms.Responses
{
    public static class ResponseEfCoreQueryableExtensions
    {
        public static IQueryable<Response> IncludeDetails(this IQueryable<Response> queryable, bool include = true)
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