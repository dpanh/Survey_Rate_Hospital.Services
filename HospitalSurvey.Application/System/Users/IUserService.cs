using HospitalSurvey.Application.ViewModels.Users;
using System.Threading.Tasks;

namespace HospitalSurvey.Application.System.Users
{
    public interface IUserService
    {

        Task<string> Authencate(LoginRequest request);

        Task<bool> Register(RegisterRequest request);

    }
}
