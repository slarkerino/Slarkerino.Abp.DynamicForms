using Slarkerino.Abp.DynamicForms.Answers;
using System.Threading.Tasks;

namespace Slarkerino.Abp.DynamicForms.Options.Answers
{
    public interface IAnswerResultResolver
    {
        Task ResolveAnswer(Answer answer);
    }
}
