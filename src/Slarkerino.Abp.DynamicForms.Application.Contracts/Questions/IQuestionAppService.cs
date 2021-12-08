using System;
using Slarkerino.Abp.DynamicForms.Questions.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Slarkerino.Abp.DynamicForms.Questions
{
    public interface IQuestionAppService :
        ICrudAppService< 
            QuestionDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            QuestionCreateDto,
            QuestionUpdateDto>
    {

    }
}