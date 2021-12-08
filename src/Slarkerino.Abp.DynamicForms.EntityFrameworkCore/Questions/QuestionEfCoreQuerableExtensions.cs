using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Slarkerino.Abp.DynamicForms.Questions
{
    public static class QuestionEfCoreQueryableExtensions
    {
        public static IQueryable<Question> IncludeDetails(this IQueryable<Question> queryable, bool include = true)
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