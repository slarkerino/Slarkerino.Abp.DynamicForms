using Slarkerino.Abp.DynamicForms.Options.Answers;
using Slarkerino.Abp.DynamicForms.Options.QuestionTypes;
using System.Collections.Generic;

namespace Slarkerino.Abp.DynamicForms.Options
{
    public class DynamicFormsOptions
    {
        public QuestionTypeConfigurations QuestionTypes { get; }

        public List<IAnswerValidator> Validators { get; }

        public DynamicFormsOptions()
        {
            QuestionTypes = new QuestionTypeConfigurations();

            Validators = new List<IAnswerValidator>();
        }
    }
}
