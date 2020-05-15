using HospitalSurvey.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalSurvey.Data.Configurations
{
    public class PermissionDetailConfiguration : IEntityTypeConfiguration<PermissionDetail>
    {
        public void Configure(EntityTypeBuilder<PermissionDetail> builder)
        {
            builder.ToTable("PermissionDetails");
            builder.HasKey(x => x.Id);


            builder.Property(x => x.HasCreate).IsRequired();
            builder.Property(x => x.HasDetele).IsRequired();
            builder.Property(x => x.HasUpdate).IsRequired();
            builder.Property(x => x.HasRead).IsRequired();


            builder.HasOne(x => x.Permission).WithMany(x => x.PermissionDetails).HasForeignKey(x => x.PermissionId);
            builder.HasOne(x => x.Function).WithMany(x => x.PermissionDetails).HasForeignKey(x => x.FunctionId);

        }
    }
}
