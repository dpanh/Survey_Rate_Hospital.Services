using HospitalSurvey.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalSurvey.Data.Configurations
{
    public class SurveyQuestionConfiguration : IEntityTypeConfiguration<SurveyQuestion>
    {
        public void Configure(EntityTypeBuilder<SurveyQuestion> builder)
        {
            builder.ToTable("SurveyQuestions");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Logo).IsRequired();
            builder.Property(x => x.Content).IsRequired();
            builder.HasOne(x => x.SatisfactionLevel).WithMany(x => x.SurveyQuestions).HasForeignKey(x => x.SatisfactionLevelId);
        }
    }
}
