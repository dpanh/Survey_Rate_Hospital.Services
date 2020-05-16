using HospitalSurvey.Data.Entities;
using HospitalSurvey.Data.Enums;
using System;
using System.Collections.Generic;

namespace HospitalSurvey.Application.ViewModels
{
    public class HospitalDepartmentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string Logo { get; set; }

        public string WelcomeMessage { get; set; }

        public string BackgroundImage { get; set; }

        public string Description { get; set; }

        public string Calendar { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }

        public List<Staff> Staffs { get; set; }

        public List<SatisfactionLevel> SatisfactionLevels { get; set; }
    }
}
