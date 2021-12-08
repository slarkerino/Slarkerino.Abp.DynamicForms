using System;
using System.Threading.Tasks;
using Slarkerino.Abp.DynamicForms.Responses.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Slarkerino.Abp.DynamicForms.Responses
{
    public class ResponseAppService : CrudAppService<Response, ResponseDto, Guid, PagedAndSortedResultRequestDto, ResponseCreateDto, ResponseUpdateDto>,
        IResponseAppService
    {

        private readonly IResponseRepository _repository;
        
        public ResponseAppService(IResponseRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override async Task<ResponseDto> CreateAsync(ResponseCreateDto input)
        {
            return await base.CreateAsync(input);
        }
    }
}
