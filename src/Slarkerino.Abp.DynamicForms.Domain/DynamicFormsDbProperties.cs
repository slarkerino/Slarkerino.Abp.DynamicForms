namespace Slarkerino.Abp.DynamicForms
{
    public static class DynamicFormsDbProperties
    {
        public static string DbTablePrefix { get; set; } = "DynamicForms";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "DynamicForms";
    }
}
