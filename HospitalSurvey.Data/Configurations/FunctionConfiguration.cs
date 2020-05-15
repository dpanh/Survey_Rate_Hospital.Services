using HospitalSurvey.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalSurvey.Data.Configurations
{
    public class FunctionConfiguration : IEntityTypeConfiguration<Function>
    {
        public void Configure(EntityTypeBuilder<Function> builder)
        {
            builder.ToTable("Functions");
            builder.HasKey(x => x.Id);


            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Path).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Icon).IsRequired();
        }
    }
}
