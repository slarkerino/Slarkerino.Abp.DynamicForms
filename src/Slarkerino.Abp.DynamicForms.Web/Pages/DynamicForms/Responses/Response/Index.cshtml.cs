using System.Threading.Tasks;

namespace Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Responses.Response
{
    public class IndexModel : DynamicFormsPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
