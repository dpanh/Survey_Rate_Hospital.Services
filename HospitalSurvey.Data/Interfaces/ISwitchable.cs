using HospitalSurvey.Data.Enums;

namespace HospitalSurvey.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
