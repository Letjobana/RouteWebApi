using RoutePlannerWebAPI.Models;
using System.Collections.Generic;

namespace RoutePlanWebApi.Repositories.Abstracts
{
    public interface IDriverRepositorycs
    {
        IEnumerable<Driver> GetAllDrivers();
        Driver AddDrivers(Driver driver);
        bool DriverExist(string name);
    }
}
