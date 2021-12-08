using System;
using Volo.Abp.Data;

namespace Slarkerino.Abp.DynamicForms.Answers
{
    public interface IAnswer : IHasExtraProperties
    {
        Guid QuestionId { get; }

        string Result { get; }

        string QuestionType { get; }

        string QuestionTitle { get; }
    }
}
