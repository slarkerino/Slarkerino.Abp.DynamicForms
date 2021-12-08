using Slarkerino.Abp.DynamicForms.Options.QuestionTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slarkerino.Abp.DynamicForms.Options
{
    public class DynamicFormsQuestionsOptions
    {
        public QuestionTypeConfigurations QuestionTypes { get; }

        public DynamicFormsQuestionsOptions()
        {
            QuestionTypes = new QuestionTypeConfigurations();
        }
    }
}
