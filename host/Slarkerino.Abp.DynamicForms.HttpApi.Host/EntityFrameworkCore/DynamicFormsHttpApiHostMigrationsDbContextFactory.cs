using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Slarkerino.Abp.DynamicForms.EntityFrameworkCore
{
    public class DynamicFormsHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<DynamicFormsHttpApiHostMigrationsDbContext>
    {
        public DynamicFormsHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<DynamicFormsHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("DynamicForms"));

            return new DynamicFormsHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
