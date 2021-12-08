using Slarkerino.Abp.DynamicForms.Answers;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Slarkerino.Abp.DynamicForms.Options.Answers
{
    public class DefaultAnswerResolver : IAnswerResultResolver, ITransientDependency
    {
        public Task ResolveAnswer(Answer answer)
        {
            answer.SetResult(string.Empty);

            return Task.CompletedTask;
        }
    }
}
