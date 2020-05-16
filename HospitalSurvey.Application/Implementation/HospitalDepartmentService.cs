using AutoMapper;
using HospitalSurvey.Application.Interfaces;
using HospitalSurvey.Application.ViewModels;
using HospitalSurvey.Data.Entities;
using HospitalSurvey.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HospitalSurvey.Application.Implementation
{
    public class HospitalDepartmentService : IHospitalDepartmentService
    {
        private IRepository<HospitalDepartment, int> _hospitalDepartmentRepository;
        private IUnitOfWork _unitOfWork;

        public HospitalDepartmentService(
            IRepository<HospitalDepartment, int> hospitalDepartmentRepository,
            IUnitOfWork unitOfWork

            )
        {
            this._hospitalDepartmentRepository = hospitalDepartmentRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(HospitalDepartmentViewModel hospitalDepartmentview)
        {
            var hos = Mapper.Map<HospitalDepartmentViewModel, HospitalDepartment>(hospitalDepartmentview);
            _hospitalDepartmentRepository.Add(hos);
        }

        public bool CheckExistedId(int id)
        {
            var hos = _hospitalDepartmentRepository.FindById(id);
            return (hos == null) ? false : true;
        }

        public void Delete(int id)
        {
            var course = _hospitalDepartmentRepository.FindById(id);

            _hospitalDepartmentRepository.Remove(course);

        }


        public Task<List<HospitalDepartmentViewModel>> GetAll(string filter)
        {
            throw new NotImplementedException();
        }

 
        public HospitalDepartmentViewModel GetById(int id)
        {
            var hos = _hospitalDepartmentRepository.FindById(id);
            if (hos == null)
                return new HospitalDepartmentViewModel();

            return Mapper.Map<HospitalDepartment, HospitalDepartmentViewModel>(hos);

        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(HospitalDepartmentViewModel function)
        {
            var hos = Mapper.Map<HospitalDepartmentViewModel, HospitalDepartment>(function);
            _hospitalDepartmentRepository.Update(hos);
        }
    }
}
