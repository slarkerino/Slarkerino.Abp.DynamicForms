using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Slarkerino.Abp.DynamicForms.Blazor.Server.Host
{
    [Dependency(ReplaceServices = true)]
    public class DynamicFormsBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "DynamicForms";
    }
}
