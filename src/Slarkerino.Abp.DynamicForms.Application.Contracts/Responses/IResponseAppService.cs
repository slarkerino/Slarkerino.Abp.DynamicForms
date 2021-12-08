using System;
using Slarkerino.Abp.DynamicForms.Responses.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Slarkerino.Abp.DynamicForms.Responses
{
    public interface IResponseAppService :
        ICrudAppService< 
            ResponseDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            ResponseCreateDto,
            ResponseUpdateDto>
    {

    }
}