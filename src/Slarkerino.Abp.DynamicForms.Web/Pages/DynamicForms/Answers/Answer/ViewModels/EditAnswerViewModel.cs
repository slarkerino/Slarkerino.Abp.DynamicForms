using System;

using System.ComponentModel.DataAnnotations;

namespace Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Answers.Answer.ViewModels
{
    public class EditAnswerViewModel
    {
        [Display(Name = "AnswerQuestionId")]
        public Guid QuestionId { get; set; }

        [Display(Name = "AnswerQuestionType")]
        public string QuestionType { get; set; }

        [Display(Name = "AnswerQuestionTitle")]
        public string QuestionTitle { get; set; }

        [Display(Name = "AnswerExtraProperties")]
        public ExtraPropertyDictionary ExtraProperties { get; set; }

        [Display(Name = "AnswerResult")]
        public string Result { get; set; }
    }
}