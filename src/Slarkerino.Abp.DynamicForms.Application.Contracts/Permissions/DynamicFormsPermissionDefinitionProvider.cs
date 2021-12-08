using Slarkerino.Abp.DynamicForms.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Slarkerino.Abp.DynamicForms.Permissions
{
    public class DynamicFormsPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(DynamicFormsPermissions.GroupName, L("Permission:DynamicForms"));

            var projectPermission = myGroup.AddPermission(DynamicFormsPermissions.Project.Default, L("Permission:Project"));
            projectPermission.AddChild(DynamicFormsPermissions.Project.Manage, L("Permission:Manage"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<DynamicFormsResource>(name);
        }
    }
}
