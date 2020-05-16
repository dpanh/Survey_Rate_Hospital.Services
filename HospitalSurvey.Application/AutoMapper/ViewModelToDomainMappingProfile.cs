using AutoMapper;
using HospitalSurvey.Application.ViewModels;
using HospitalSurvey.Data.Entities;

namespace HospitalSurvey.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {

            CreateMap<AppRoleViewModel, AppRole>();
            CreateMap<AppUserViewModel, AppUser>();


            CreateMap<ContactViewModel, Contact>();


            CreateMap<FeedbackViewModel, Feedback>();

            CreateMap<FunctionViewModel, Function>();

            CreateMap<HospitalDepartmentViewModel, HospitalDepartment>();


            CreateMap<PermissionViewModel, Permission>();


            CreateMap<AnnouncementViewModel, Announcement>()
                .ConstructUsing(c => new Announcement(c.Title, c.Content, c.UserId, c.Status));

            CreateMap<AnnouncementUserViewModel, AnnouncementUser>()
                .ConstructUsing(c => new AnnouncementUser(c.AnnouncementId, c.UserId, c.HasRead));

        }
    }
}
