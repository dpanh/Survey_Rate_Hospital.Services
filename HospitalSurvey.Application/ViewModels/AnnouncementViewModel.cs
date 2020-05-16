using HospitalSurvey.Data.Enums;
using System;

namespace HospitalSurvey.Application.ViewModels
{
    public class AnnouncementViewModel
    {
        public string Id { get; set; }
       
        public string Title { set; get; }

        public string Content { set; get; }

        public Guid UserId { set; get; }

        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public Status Status { set; get; }
    }
}
