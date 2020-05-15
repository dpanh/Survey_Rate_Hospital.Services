using HospitalSurvey.Data.Enums;
using HospitalSurvey.Data.Interfaces;
using HospitalSurvey.Infrastructure.SharedKernel;
using System;

namespace HospitalSurvey.Data.Entities
{
    public class PermissionDetail : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public bool IsRead { get; set; }
        public bool HasUpdate { get; set; }
        public bool HasCreate { get; set; }
        public bool HasRead { get; set; }
        public bool HasDetele { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }


        public Function Function { get; set; }

        public Permission Permission { get; set; }

        public int FunctionId { get; set; }

        public int PermissionId { get; set; }
    }
}
