using HospitalSurvey.Data.Enums;
using HospitalSurvey.Data.Interfaces;
using HospitalSurvey.Infrastructure.SharedKernel;

namespace HospitalSurvey.Data.Entities
{
    public class Language : DomainEntity<string>, ISwitchable
    {

        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public string Resources { get; set; }

        public Status Status { get; set; }
    }
}
