using System;
using Slarkerino.Abp.DynamicForms.Answers.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Slarkerino.Abp.DynamicForms.Answers
{
    public interface IAnswerAppService :
        ICrudAppService< 
            AnswerDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            AnswerCreateDto,
            AnswerUpdateDto>
    {

    }
}