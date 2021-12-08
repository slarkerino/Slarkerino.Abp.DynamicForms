using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Slarkerino.Abp.DynamicForms.Questions;
using Slarkerino.Abp.DynamicForms.Questions.Dtos;
using Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Questions.Question.ViewModels;

namespace Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Questions.Question
{
    public class CreateModalModel : DynamicFormsPageModel
    {
        [BindProperty]
        public CreateQuestionViewModel ViewModel { get; set; }

        private readonly IQuestionAppService _service;

        public CreateModalModel(IQuestionAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateQuestionViewModel, QuestionCreateDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}