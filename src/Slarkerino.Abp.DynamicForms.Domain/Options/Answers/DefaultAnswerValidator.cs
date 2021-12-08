using Slarkerino.Abp.DynamicForms.Answers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Slarkerino.Abp.DynamicForms.Options.Answers
{
    public class DefaultAnswerValidator : IAnswerValidator
    {
        public Task Validate(Answer answer)
        {
            return Task.CompletedTask;
        }
    }
}
