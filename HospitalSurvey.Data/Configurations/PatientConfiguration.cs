using HospitalSurvey.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalSurvey.Data.Configurations
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("Patients");
            builder.HasKey(x => x.Id);


            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.IdCard).IsRequired().HasMaxLength(12);
        }
    }
}
