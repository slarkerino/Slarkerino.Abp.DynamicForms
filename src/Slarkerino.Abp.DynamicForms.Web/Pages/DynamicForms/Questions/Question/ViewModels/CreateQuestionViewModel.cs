using System;

using System.ComponentModel.DataAnnotations;

namespace Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Questions.Question.ViewModels
{
    public class CreateQuestionViewModel
    {
        [Display(Name = "QuestionTitle")]
        public string Title { get; set; }

        [Display(Name = "QuestionExtraProperties")]
        public ExtraPropertyDictionary ExtraProperties { get; set; }

        [Display(Name = "QuestionQuestionType")]
        public string QuestionType { get; set; }

        [Display(Name = "QuestionMinScore")]
        public int MinScore { get; set; }

        [Display(Name = "QuestionMaxScore")]
        public int MaxScore { get; set; }
    }
}