using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Slarkerino.Abp.DynamicForms.Answers
{
    public static class AnswerEfCoreQueryableExtensions
    {
        public static IQueryable<Answer> IncludeDetails(this IQueryable<Answer> queryable, bool include = true)
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