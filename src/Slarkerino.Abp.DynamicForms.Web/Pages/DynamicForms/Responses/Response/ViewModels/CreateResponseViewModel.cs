using System;

using System.ComponentModel.DataAnnotations;

namespace Slarkerino.Abp.DynamicForms.Web.Pages.DynamicForms.Responses.Response.ViewModels
{
    public class CreateResponseViewModel
    {
        [Display(Name = "ResponseSequence")]
        public int Sequence { get; set; }

        [Display(Name = "ResponseStartTime")]
        public DateTime StartTime { get; set; }

        [Display(Name = "ResponseEndTime")]
        public DateTime EndTime { get; set; }

        [Display(Name = "ResponseSource")]
        public string Source { get; set; }

        [Display(Name = "ResponseProjectId")]
        public Guid ProjectId { get; set; }

        [Display(Name = "ResponseAnswers")]
        public ICollection<Answer> Answers { get; set; }
    }
}