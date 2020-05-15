using HospitalSurvey.Data.Enums;
using HospitalSurvey.Data.Interfaces;
using HospitalSurvey.Infrastructure.SharedKernel;
using System;

namespace HospitalSurvey.Data.Entities
{
    public class Staff : DomainEntity<int>, ISwitchable, IDateTracking
    {

        public string Name { get; set; }

        public string Position { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
        
        public int HospitalDepartmentId { get; set; }
        public HospitalDepartment HospitalDepartment { get; set; }
    }
}
