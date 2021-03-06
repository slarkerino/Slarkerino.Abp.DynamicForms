using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.DependencyInjection;

namespace Slarkerino.Abp.DynamicForms.Options.QuestionTypes
{
    public class QuestionTypeConfigurationProvider : IQuestionTypeConfigurationProvider, ITransientDependency
    {
        private readonly DynamicFormsOptions _options;

        public QuestionTypeConfigurationProvider(IOptions<DynamicFormsOptions> options)
        {
            _options = options.Value;
        }

        public QuestionTypeConfiguration Get(string questionTypeName)
        {
            return _options.QuestionTypes.GetConfiguration(questionTypeName);
        }
    }
}
