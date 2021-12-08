using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Volo.Abp;

namespace Slarkerino.Abp.DynamicForms.Options.QuestionTypes
{
    public class QuestionTypeNameAttribute : Attribute
    {
        [NotNull]
        public string Name { get; }

        public QuestionTypeNameAttribute([NotNull] string name)
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));

            Name = name;
        }

        public virtual string GetName(Type type)
        {
            return Name;
        }

        public static string GetQuestionTypeName<T>()
        {
            return GetQuestionTypeName(typeof(T));
        }

        public static string GetQuestionTypeName(Type type)
        {
            var nameAttribute = type.GetCustomAttribute<QuestionTypeNameAttribute>();

            if (nameAttribute == null)
            {
                return type.FullName;
            }

            return nameAttribute.GetName(type);
        }
    }
}
