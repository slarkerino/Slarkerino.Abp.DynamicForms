using Slarkerino.Abp.DynamicForms.Answers.Dtos;
using System;
using System.Collections.Generic;
using Volo.Abp.ObjectExtending;

namespace Slarkerino.Abp.DynamicForms.Responses.Dtos
{
    [Serializable]
    public class ResponseCreateDto : ExtensibleObject
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Source { get; set; }

        public Guid ProjectId { get; set; }

        public List<AnswerCreateDto> Answers { get; set; }
    }
}