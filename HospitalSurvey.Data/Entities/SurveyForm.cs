using HospitalSurvey.Data.Enums;
using HospitalSurvey.Data.Interfaces;
using HospitalSurvey.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;

namespace HospitalSurvey.Data.Entities
{
    public class SurveyForm : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public string OtherReviewImage { get; set; }
        public string OtherReview { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }

        public List<SurveyFormDetail> SurveyFormDetails { get; set; }
    }
}
