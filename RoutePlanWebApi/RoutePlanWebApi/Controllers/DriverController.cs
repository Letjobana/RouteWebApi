using Microsoft.AspNetCore.Mvc;
using RoutePlanWebApi.Repositories.Abstracts;
using RoutePlanWebApi.ViewModel;
using System;
using System.Linq;

namespace RoutePlanWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public DriverController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetDriver()
        {

            return Ok(unitOfWork.driverRepository.GetAllDrivers());
        }
        [HttpGet]
        public IActionResult GetDepartment()
        {

            try
            {
                var dept = unitOfWork.driverRepository.GetAllDepartment().Select(r =>
                new
                {
                    Id = r.Id,
                    DepartmentName = r.DepartmentName
                }
               );
                return Ok(dept);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpGet]
        public IActionResult GetSection()
        {

            try
            {
                var sect = unitOfWork.driverRepository.GetAllSection().Select(r =>
                new
                {
                    Id = r.Id,
                    SectionName = r.SectionName
                }
               );
                return Ok(sect);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpPost]
        public IActionResult AddDriver([FromForm] DriverModel driver)
        {
            try
            {
                return Ok(unitOfWork.driverRepository.AddDrivers(driver));
            }
            catch (Exception)
            {
                throw new ArgumentException("An error has occured,please try again");

            }

        }

    }
}
