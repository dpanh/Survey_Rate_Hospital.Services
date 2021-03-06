﻿using HospitalSurvey.Data.Enums;
using HospitalSurvey.Data.Interfaces;
using HospitalSurvey.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;

namespace HospitalSurvey.Data.Entities
{
    public class Patient : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public string IdCard { get; set; }
        public string Name { get; set; }
    
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }

        public List<SurveyForm> SurveyForms { get; set; }
    }
}
