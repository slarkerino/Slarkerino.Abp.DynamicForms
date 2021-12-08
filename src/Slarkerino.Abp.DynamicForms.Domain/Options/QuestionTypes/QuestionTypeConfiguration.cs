using System;

namespace Slarkerino.Abp.DynamicForms.Options.QuestionTypes
{
    public class QuestionTypeConfiguration
    {
        public string DisplayName { get; set; }

        public string Description { get; set; }

        public string MediaResources { get; set; }

        public Type AnswerResultResolver { get; set; }
    }
}
