using RoutePlanWebApi.Models;
using RoutePlanWebApi.ViewModel;
using System.Collections.Generic;

namespace RoutePlanWebApi.Repositories.Abstracts
{
    public interface IDriverRepository
    {
        IEnumerable<Driver> GetAllDrivers();
        IEnumerable<Department> GetAllDepartment();
        public IEnumerable<Section> GetAllSection();
        Driver AddDrivers(DriverModel driver);
        bool DriverExist(string name);
    }
}
