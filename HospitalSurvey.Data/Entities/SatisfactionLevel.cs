using HospitalSurvey.Data.Enums;
using HospitalSurvey.Data.Interfaces;
using HospitalSurvey.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;

namespace HospitalSurvey.Data.Entities
{
    public class SatisfactionLevel : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public string Logo { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }

        public int HospitalDepartmentId { get; set; }
        public HospitalDepartment HospitalDepartment { get; set; }

        public List<SurveyQuestion> SurveyQuestions { get; set; }

        public List<SurveyForm> SurveyForms { get; set; }
    }
}
