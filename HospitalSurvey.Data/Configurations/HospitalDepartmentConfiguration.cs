using HospitalSurvey.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalSurvey.Data.Configurations
{
    public class HospitalDepartmentConfiguration : IEntityTypeConfiguration<HospitalDepartment>
    {

        public void Configure(EntityTypeBuilder<HospitalDepartment> builder)
        {
            builder.ToTable("HospitalDepartments");
            builder.HasKey(x => x.Id);


            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Address).HasMaxLength(200);
            builder.Property(x => x.Logo).IsRequired();
        
            builder.Property(x => x.BackgroundImage).IsRequired();

      
        }
    }
}
