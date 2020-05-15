using HospitalSurvey.Data.Enums;
using HospitalSurvey.Data.Interfaces;
using HospitalSurvey.Infrastructure.SharedKernel;
using System;

namespace HospitalSurvey.Data.Entities
{
    public class SurveyFormDetail : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }

        public DateTime ActiveTime { get; set; }
        public SurveyQuestion SurveyQuestion { get; set; }

        public SurveyForm SurveyForm { get; set; }

        public int SurveyQuestionId { get; set; }
        public int SurveyFormId { get; set; }

    }
}
