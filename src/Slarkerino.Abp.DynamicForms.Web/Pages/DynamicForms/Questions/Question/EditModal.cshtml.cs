using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Slarkerino.Abp.DynamicForms.Questions;
using Slarkerino.Abp.DynamicForms.Questions.Dtos;
using Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Questions.Question.ViewModels;

namespace Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Questions.Question
{
    public class EditModalModel : DynamicFormsPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public EditQuestionViewModel ViewModel { get; set; }

        private readonly IQuestionAppService _service;

        public EditModalModel(IQuestionAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<QuestionDto, EditQuestionViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<EditQuestionViewModel, QuestionUpdateDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}