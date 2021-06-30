using Microsoft.AspNetCore.Mvc;
using RoutePlanWebApi.Repositories.Abstracts;
using RoutePlanWebApi.ViewModel;
using System;

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
        public IActionResult GetDriver()
        {

            return Ok(unitOfWork.driverRepository.GetAllDrivers());
        }
        public IActionResult AddDriver(DriverModel driver)
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
