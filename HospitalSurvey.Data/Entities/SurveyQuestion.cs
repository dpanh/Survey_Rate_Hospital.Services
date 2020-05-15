using HospitalSurvey.Data.Enums;
using HospitalSurvey.Data.Interfaces;
using HospitalSurvey.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;

namespace HospitalSurvey.Data.Entities
{
    public class SurveyQuestion : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public string Logo { get; set; }
        public string Content { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }

        public int SatisfactionLevelId { get; set; }
        public SatisfactionLevel SatisfactionLevel { get; set; }

        public List<SurveyFormDetail> SurveyFormDetails { get; set; }
    }
}
