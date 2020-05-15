using HospitalSurvey.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalSurvey.Data.Configurations
{
    public class SatisfactionLevelConiguration : IEntityTypeConfiguration<SatisfactionLevel>
    {
        public void Configure(EntityTypeBuilder<SatisfactionLevel> builder)
        {
            builder.ToTable("SatisfactionLevels");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Logo).IsRequired();
            builder.Property(x => x.Content).IsRequired().HasMaxLength(200);


            builder.HasOne(x => x.HospitalDepartment).WithMany(x => x.SatisfactionLevels).HasForeignKey(x => x.HospitalDepartmentId);
        }
    }
}
