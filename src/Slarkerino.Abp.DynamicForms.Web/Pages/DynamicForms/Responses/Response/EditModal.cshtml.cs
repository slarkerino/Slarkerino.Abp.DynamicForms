using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Slarkerino.Abp.DynamicForms.Responses;
using Slarkerino.Abp.DynamicForms.Responses.Dtos;
using Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Responses.Response.ViewModels;

namespace Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Responses.Response
{
    public class EditModalModel : DynamicFormsPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public EditResponseViewModel ViewModel { get; set; }

        private readonly IResponseAppService _service;

        public EditModalModel(IResponseAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<ResponseDto, EditResponseViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<EditResponseViewModel, ResponseUpdateDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}