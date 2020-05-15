using HospitalSurvey.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalSurvey.Data.Configurations
{
    public class SurveyFormConfiguration : IEntityTypeConfiguration<SurveyForm>
    {
        public void Configure(EntityTypeBuilder<SurveyForm> builder)
        {
            builder.ToTable("SurveyForms");
            builder.HasKey(x => x.Id);


            builder.Property(x => x.FromTime).IsRequired();
            builder.Property(x => x.ToTime).IsRequired();

            builder.Property(x => x.OtherReview).IsRequired().HasMaxLength(500);
            builder.Property(x => x.OtherReviewImage).IsRequired();
        }
    }
}
