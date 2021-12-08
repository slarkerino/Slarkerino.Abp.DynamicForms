using System.Threading.Tasks;

namespace Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Questions.Question
{
    public class IndexModel : DynamicFormsPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
