using Slarkerino.Abp.DynamicForms.Answers;
using Slarkerino.Abp.DynamicForms.Responses;
using Slarkerino.Abp.DynamicForms.Questions;
using Slarkerino.Abp.DynamicForms.Projects;
using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Slarkerino.Abp.DynamicForms.EntityFrameworkCore
{
    public static class DynamicFormsDbContextModelCreatingExtensions
    {
        public static void ConfigureDynamicForms(
            this ModelBuilder builder,
            Action<DynamicFormsModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new DynamicFormsModelBuilderConfigurationOptions(
                DynamicFormsDbProperties.DbTablePrefix,
                DynamicFormsDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureByConvention();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */


            builder.Entity<Project>(b =>
            {
                b.ToTable(options.TablePrefix + "Projects", options.Schema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });


            builder.Entity<Question>(b =>
            {
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });


            builder.Entity<Response>(b =>
            {
                b.ToTable(options.TablePrefix + "Responses", options.Schema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });


            builder.Entity<Answer>(b =>
            {
                b.ToTable(options.TablePrefix + "Answers", options.Schema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });
        }
    }
}
