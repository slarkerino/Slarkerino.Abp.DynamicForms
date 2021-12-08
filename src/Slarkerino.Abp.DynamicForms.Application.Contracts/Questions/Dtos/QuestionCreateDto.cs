using System;
using System.ComponentModel;
using Volo.Abp.ObjectExtending;

namespace Slarkerino.Abp.DynamicForms.Questions.Dtos
{
    [Serializable]
    public class QuestionCreateDto : ExtensibleObject
    {
        public string Title { get; set; }

        public string QuestionType { get; set; }

        public int MinScore { get; set; }

        public int MaxScore { get; set; }
    }
}