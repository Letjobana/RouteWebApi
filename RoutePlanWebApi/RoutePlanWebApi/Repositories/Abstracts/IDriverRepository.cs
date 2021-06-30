using RoutePlannerWebAPI.Models;
using RoutePlanWebApi.ViewModel;
using System.Collections.Generic;

namespace RoutePlanWebApi.Repositories.Abstracts
{
    public interface IDriverRepository
    {
        IEnumerable<Driver> GetAllDrivers();
        Driver AddDrivers(DriverModel driver);
        bool DriverExist(string name);
    }
}
