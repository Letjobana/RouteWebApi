using RoutePlannerWebAPI.Models;
using System.Collections.Generic;

namespace RoutePlanWebApi.Repositories.Abstracts
{
    public interface IDriverRepository
    {
        IEnumerable<Driver> GetAllDrivers();
        Driver AddDrivers(Driver driver);
        bool DriverExist(string name);
    }
}
