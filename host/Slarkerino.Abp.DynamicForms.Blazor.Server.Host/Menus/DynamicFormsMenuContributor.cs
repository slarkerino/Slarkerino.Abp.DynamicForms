using System.Threading.Tasks;
using Slarkerino.Abp.DynamicForms.Localization;
using Slarkerino.Abp.DynamicForms.Permissions;
using Slarkerino.Abp.DynamicForms.MultiTenancy;
using Volo.Abp.Identity.Blazor;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.UI.Navigation;

namespace Slarkerino.Abp.DynamicForms.Blazor.Server.Host.Menus
{
    public class DynamicFormsMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenu(MenuConfigurationContext context)
        {
            var l = context.GetLocalizer<DynamicFormsResource>();
             var administration = context.Menu.GetAdministration();

            if (MultiTenancyConsts.IsEnabled)
            {
                administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
            }
            else
            {
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
            administration.SetSubItemOrder(SettingManagementMenus.GroupName, 3);

            if (await context.IsGrantedAsync(DynamicFormsPermissions.Project.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem(DynamicFormsMenus.Project, l["Menu:Project"], "/DynamicForms/Projects/Project")
                );
            }
            context.Menu.AddItem(
                new ApplicationMenuItem(DynamicFormsMenus.Question, l["Menu:Question"], "/DynamicForms/Questions/Question")
            );
            context.Menu.AddItem(
                new ApplicationMenuItem(DynamicFormsMenus.Response, l["Menu:Response"], "/DynamicForms/Responses/Response")
            );
            context.Menu.AddItem(
                new ApplicationMenuItem(DynamicFormsMenus.Answer, l["Menu:Answer"], "/DynamicForms/Answers/Answer")
            );
        }
    }
}
