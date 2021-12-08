using Slarkerino.Abp.DynamicForms.Projects.Dtos;
using Slarkerino.Abp.DynamicForms.Questions;
using Slarkerino.Abp.DynamicForms.Questions.Dtos;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Slarkerino.Abp.DynamicForms.Projects
{
    public class ProjectAppService : CrudAppService<Project, ProjectDto, Guid, PagedAndSortedResultRequestDto, ProjectCreateDto, ProjectUpdateDto>,
        IProjectAppService
    {

        private readonly IProjectRepository _repository;
        
        public ProjectAppService(IProjectRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task AddQuestion(Guid id, QuestionCreateDto input)
        {
            var project = await Repository.GetAsync(id);

            Question question = ObjectMapper.Map<QuestionCreateDto, Question>(input);

            project.AddQuestion(question);

            await Repository.UpdateAsync(project);
        }

        public async Task UpdateQuestion(Guid id, QuestionUpdateDto input)
        {
            var project = await Repository.GetAsync(id);

            var question = project.Questions.Single(x => x.Id == input.Id);

            ObjectMapper.Map(input, question);

            await Repository.UpdateAsync(project);
        }
    }
}
