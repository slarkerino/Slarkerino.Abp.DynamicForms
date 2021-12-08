using Slarkerino.Abp.DynamicForms.Answers.Dtos;
using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Slarkerino.Abp.DynamicForms.Responses.Dtos
{
    [Serializable]
    public class ResponseDto : ExtensibleFullAuditedEntityDto<Guid>
    {
        public int Sequence { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Source { get; set; }

        public Guid ProjectId { get; set; }

        public List<AnswerDto> Answers { get; set; }
    }
}