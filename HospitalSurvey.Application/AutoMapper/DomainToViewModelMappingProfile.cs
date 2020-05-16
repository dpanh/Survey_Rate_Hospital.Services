using AutoMapper;
using HospitalSurvey.Application.ViewModels;
using HospitalSurvey.Data.Entities;

namespace HospitalSurvey.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<AppRole, AppRoleViewModel>();
            CreateMap<AppUser, AppUserViewModel>();

            CreateMap<Contact, ContactViewModel>();

            CreateMap<Feedback, FeedbackViewModel>();

            CreateMap<Function, FunctionViewModel>();


            CreateMap<Permission, PermissionViewModel>();

            CreateMap<Announcement, AnnouncementViewModel>().MaxDepth(2);


            CreateMap<HospitalDepartment, HospitalDepartmentViewModel>();
        }
    }
}
