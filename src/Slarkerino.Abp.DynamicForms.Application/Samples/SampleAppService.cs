using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Slarkerino.Abp.DynamicForms.Samples
{
    public class SampleAppService : DynamicFormsAppService, ISampleAppService
    {
        public Task<SampleDto> GetAsync()
        {
            return Task.FromResult(
                new SampleDto
                {
                    Value = 42
                }
            );
        }

        [Authorize]
        public Task<SampleDto> GetAuthorizedAsync()
        {
            return Task.FromResult(
                new SampleDto
                {
                    Value = 42
                }
            );
        }
    }
}