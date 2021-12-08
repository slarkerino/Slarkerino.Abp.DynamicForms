using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Slarkerino.Abp.DynamicForms.Projects;
using Slarkerino.Abp.DynamicForms.Projects.Dtos;
using Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Projects.Project.ViewModels;

namespace Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Projects.Project
{
    public class CreateModalModel : DynamicFormsPageModel
    {
        [BindProperty]
        public CreateProjectViewModel ViewModel { get; set; }

        private readonly IProjectAppService _service;

        public CreateModalModel(IProjectAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateProjectViewModel, ProjectCreateDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}