using System;
using System.Threading.Tasks;
using Slarkerino.Abp.DynamicForms.Projects.Dtos;
using Slarkerino.Abp.DynamicForms.Questions.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Slarkerino.Abp.DynamicForms.Projects
{
    public interface IProjectAppService :
        ICrudAppService< 
            ProjectDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            ProjectCreateDto,
            ProjectUpdateDto>
    {
        Task AddQuestion(Guid id, QuestionCreateDto input);

        Task UpdateQuestion(Guid id, QuestionUpdateDto input);
    }
}