using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Slarkerino.Abp.DynamicForms.Answers;
using Slarkerino.Abp.DynamicForms.Answers.Dtos;
using Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Answers.Answer.ViewModels;

namespace Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Answers.Answer
{
    public class EditModalModel : DynamicFormsPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public EditAnswerViewModel ViewModel { get; set; }

        private readonly IAnswerAppService _service;

        public EditModalModel(IAnswerAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<AnswerDto, EditAnswerViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<EditAnswerViewModel, AnswerUpdateDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}