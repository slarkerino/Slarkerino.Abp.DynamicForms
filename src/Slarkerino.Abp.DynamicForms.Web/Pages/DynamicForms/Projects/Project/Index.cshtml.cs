using System.Threading.Tasks;

namespace Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Projects.Project
{
    public class IndexModel : DynamicFormsPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
