using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Slarkerino.Abp.DynamicForms.Answers;
using Slarkerino.Abp.DynamicForms.Answers.Dtos;
using Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Answers.Answer.ViewModels;

namespace Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Answers.Answer
{
    public class CreateModalModel : DynamicFormsPageModel
    {
        [BindProperty]
        public CreateAnswerViewModel ViewModel { get; set; }

        private readonly IAnswerAppService _service;

        public CreateModalModel(IAnswerAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateAnswerViewModel, AnswerCreateDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}