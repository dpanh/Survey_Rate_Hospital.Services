using HospitalSurvey.Data.Enums;
using System;

namespace HospitalSurvey.Application.ViewModels
{
    public class PermissionViewModel
    {
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
    }
}
