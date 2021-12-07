using Volo.Abp.Reflection;

namespace Slarkerino.Abp.DynamicForms.Permissions
{
    public class DynamicFormsPermissions
    {
        public const string GroupName = "DynamicForms";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(DynamicFormsPermissions));
        }
    }
}