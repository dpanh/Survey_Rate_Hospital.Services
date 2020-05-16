using HospitalSurvey.Application.Interfaces;
using HospitalSurvey.Application.ViewModels;
using HospitalSurvey.Data.EF;
using HospitalSurvey.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HospitalSurvey.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalDepartmentController : ControllerBase
    {
        private readonly HospitalSurveyDbContext _context;

        private readonly IHospitalDepartmentService _hospitalDepartmentService;
        public HospitalDepartmentController(
            HospitalSurveyDbContext context,
            IHospitalDepartmentService hospitalDepartmentService)
        {
            _hospitalDepartmentService = hospitalDepartmentService;
            _context = context;
        }

        [HttpGet]
        public async Task<List<HospitalDepartment>> GetAll()
        {
            return await _context.HospitalDepartments.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HospitalDepartment>> GetHospitalDepartmentByID(int id)
        {
            var hos = _context.HospitalDepartments.Find(id);

            if (hos == null)
            {
                return NotFound("Không tìm thấy Bộ phận có id = " + id);
            }

            return await Task.FromResult(hos);
        }


        [HttpPost]
        public ActionResult<HospitalDepartmentViewModel> PostHospitalDepartment(HospitalDepartmentViewModel hospital)
        {
            if (hospital != null)
            {
                try
                {
                    hospital.DateCreated = DateTime.Now;
                    _hospitalDepartmentService.Add(hospital);
                    _hospitalDepartmentService.SaveChanges();
                    return Ok();

                }
                catch
                {

                    throw new Exception(string.Format("Lỗi khi thêm dữ liệu"));
                }

            }

            return Ok();
        }

        [HttpPut("{id}")]
        public  IActionResult PutHospitalDepartment(int id, HospitalDepartmentViewModel viewModel)
        {
            if (viewModel.Id != id)
            {
                throw new Exception(string.Format("Id và Id của khóa học không giống nhau!"));
            }

            try
            {


                viewModel.DateModified = DateTime.Now;
                _hospitalDepartmentService.Update(viewModel);
                _hospitalDepartmentService.SaveChanges();


            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_hospitalDepartmentService.CheckExistedId(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteHospitalDepartment(int id)
        {
            try
            {
                _hospitalDepartmentService.Delete(id);
                _hospitalDepartmentService.SaveChanges();


            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_hospitalDepartmentService.CheckExistedId(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }



    }
}
