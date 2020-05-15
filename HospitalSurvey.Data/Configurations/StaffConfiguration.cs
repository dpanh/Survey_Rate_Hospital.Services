using HospitalSurvey.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalSurvey.Data.Configurations
{
    public class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.ToTable("Staffs");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired();

            builder.Property(x => x.Position).IsRequired();


            builder.Property(x => x.Username).IsRequired();

            builder.Property(x => x.Password).IsRequired();


            builder.HasOne(x => x.HospitalDepartment).WithMany(x => x.Staffs).HasForeignKey(x => x.HospitalDepartmentId);
        }
    }
}
