using HospitalSurvey.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HospitalSurvey.Application.Interfaces
{
    public interface IHospitalDepartmentService
    {
        void Add(HospitalDepartmentViewModel function);

        Task<List<HospitalDepartmentViewModel>> GetAll(string filter);

        HospitalDepartmentViewModel GetById(int id);

        void Update(HospitalDepartmentViewModel function);

        void Delete(int id);

        void SaveChanges();

        bool CheckExistedId(int id);

    }
}
