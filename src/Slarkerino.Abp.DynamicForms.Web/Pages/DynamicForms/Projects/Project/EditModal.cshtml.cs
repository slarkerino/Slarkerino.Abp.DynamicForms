using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Slarkerino.Abp.DynamicForms.Projects;
using Slarkerino.Abp.DynamicForms.Projects.Dtos;
using Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Projects.Project.ViewModels;

namespace Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Projects.Project
{
    public class EditModalModel : DynamicFormsPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public EditProjectViewModel ViewModel { get; set; }

        private readonly IProjectAppService _service;

        public EditModalModel(IProjectAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<ProjectDto, EditProjectViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<EditProjectViewModel, ProjectUpdateDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}