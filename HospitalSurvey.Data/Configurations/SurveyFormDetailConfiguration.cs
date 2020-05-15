using HospitalSurvey.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalSurvey.Data.Configurations
{
    public class SurveyFormDetailConfiguration : IEntityTypeConfiguration<SurveyFormDetail>
    {

        public void Configure(EntityTypeBuilder<SurveyFormDetail> builder)
        {
            builder.ToTable("SurveyFormDetails");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ActiveTime).IsRequired();
        
            builder.HasOne(x => x.SurveyForm).WithMany(x => x.SurveyFormDetails).HasForeignKey(x => x.SurveyFormId);
            builder.HasOne(x => x.SurveyQuestion).WithMany(x => x.SurveyFormDetails).HasForeignKey(x => x.SurveyQuestionId);
        }
    }
}
