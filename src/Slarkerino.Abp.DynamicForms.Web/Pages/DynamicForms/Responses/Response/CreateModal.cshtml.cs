using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Slarkerino.Abp.DynamicForms.Responses;
using Slarkerino.Abp.DynamicForms.Responses.Dtos;
using Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Responses.Response.ViewModels;

namespace Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Responses.Response
{
    public class CreateModalModel : DynamicFormsPageModel
    {
        [BindProperty]
        public CreateResponseViewModel ViewModel { get; set; }

        private readonly IResponseAppService _service;

        public CreateModalModel(IResponseAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateResponseViewModel, ResponseCreateDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}