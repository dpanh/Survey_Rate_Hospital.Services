using HospitalSurvey.Data.Enums;
using System;

namespace HospitalSurvey.Application.ViewModels
{
    public class FunctionViewModel
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Icon { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }

 
    }
}
