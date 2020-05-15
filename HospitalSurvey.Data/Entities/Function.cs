using HospitalSurvey.Data.Enums;
using HospitalSurvey.Data.Interfaces;
using HospitalSurvey.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;

namespace HospitalSurvey.Data.Entities
{
    public class Function : DomainEntity<int>, ISwitchable, IDateTracking
    {

        public string Name { get; set; }
        public string Path { get; set; }
        public string Icon { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }

        public List<PermissionDetail> PermissionDetails { get; set; }
    }
}
