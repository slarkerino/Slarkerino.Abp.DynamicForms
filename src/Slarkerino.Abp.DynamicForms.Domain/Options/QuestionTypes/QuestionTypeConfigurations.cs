using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Volo.Abp;
namespace Slarkerino.Abp.DynamicForms.Options.QuestionTypes
{
    public class QuestionTypeConfigurations
    {
        private readonly Dictionary<string, QuestionTypeConfiguration> _types;

        public QuestionTypeConfigurations()
        {
            _types = new Dictionary<string, QuestionTypeConfiguration>();
        }

        public QuestionTypeConfigurations Configure<Ttype>(
            Action<QuestionTypeConfiguration> configureAction)
        {
            return Configure(
                QuestionTypeNameAttribute.GetQuestionTypeName<Ttype>(),
                configureAction
            );
        }

        public QuestionTypeConfigurations Configure(
            [NotNull] string name,
            [NotNull] Action<QuestionTypeConfiguration> configureAction)
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));
            Check.NotNull(configureAction, nameof(configureAction));

            configureAction(
                _types.GetOrAdd(
                    name,
                    () => new QuestionTypeConfiguration()
                )
            );

            return this;
        }

        public QuestionTypeConfigurations ConfigureAll(Action<string, QuestionTypeConfiguration> configureAction)
        {
            foreach (var type in _types)
            {
                configureAction(type.Key, type.Value);
            }

            return this;
        }

        [NotNull]
        public QuestionTypeConfiguration GetConfiguration<Ttype>()
        {
            return GetConfiguration(QuestionTypeNameAttribute.GetQuestionTypeName<Ttype>());
        }

        [NotNull]
        public QuestionTypeConfiguration GetConfiguration([NotNull] string name)
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));

            return _types.GetOrDefault(name);
        }

        [NotNull]
        public Dictionary<string, QuestionTypeConfiguration> GetConfigurationsDictionary()
        {
            return _types;
        }
    }
}
