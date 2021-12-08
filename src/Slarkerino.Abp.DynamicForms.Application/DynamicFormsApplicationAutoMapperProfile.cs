using Slarkerino.Abp.DynamicForms.Projects;
using Slarkerino.Abp.DynamicForms.Projects.Dtos;
using Slarkerino.Abp.DynamicForms.Questions;
using Slarkerino.Abp.DynamicForms.Questions.Dtos;
using Slarkerino.Abp.DynamicForms.Responses;
using Slarkerino.Abp.DynamicForms.Responses.Dtos;
using Slarkerino.Abp.DynamicForms.Answers;
using Slarkerino.Abp.DynamicForms.Answers.Dtos;
using AutoMapper;
using Volo.Abp.ObjectExtending;

namespace Slarkerino.Abp.DynamicForms
{
    public class DynamicFormsApplicationAutoMapperProfile : Profile
    {
        public DynamicFormsApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Project, ProjectDto>().MapExtraProperties(MappingPropertyDefinitionChecks.None);
            CreateMap<ProjectCreateDto, Project>(MemberList.Source).MapExtraProperties(MappingPropertyDefinitionChecks.None);
            CreateMap<ProjectUpdateDto, Project>(MemberList.Source).MapExtraProperties(MappingPropertyDefinitionChecks.None);
            CreateMap<Question, QuestionDto>().MapExtraProperties(MappingPropertyDefinitionChecks.None);
            CreateMap<QuestionCreateDto, Question>(MemberList.Source).MapExtraProperties(MappingPropertyDefinitionChecks.None);
            CreateMap<QuestionUpdateDto, Question>(MemberList.Source).MapExtraProperties(MappingPropertyDefinitionChecks.None);
            CreateMap<Response, ResponseDto>().MapExtraProperties(MappingPropertyDefinitionChecks.None);
            CreateMap<ResponseCreateDto, Response>(MemberList.Source).MapExtraProperties(MappingPropertyDefinitionChecks.None);
            CreateMap<ResponseUpdateDto, Response>(MemberList.Source).MapExtraProperties(MappingPropertyDefinitionChecks.None);
            CreateMap<Answer, AnswerDto>().MapExtraProperties(MappingPropertyDefinitionChecks.None);
            CreateMap<AnswerCreateDto, Answer>(MemberList.Source).MapExtraProperties(MappingPropertyDefinitionChecks.None);
            CreateMap<AnswerUpdateDto, Answer>(MemberList.Source).MapExtraProperties(MappingPropertyDefinitionChecks.None);
        }
    }
}
