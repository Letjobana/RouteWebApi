using RoutePlannerWebAPI.Models;
using RoutePlanWebApi.Persistance;
using RoutePlanWebApi.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RoutePlanWebApi.Repositories.Concrets
{
    public class DriverRepository : IDriverRepository
    {
        private ApplicationDbContext context;
        public DriverRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Driver AddDrivers(Driver driver)
        {
            if (driver == null)
                throw new ArgumentNullException("driver");
            else if (DriverExist(driver.FirstName))
                throw new ArgumentException("The name already exist");
            else
                context.Drivers.Add(driver);
            context.SaveChanges();
            return driver;
        }

        public bool DriverExist(string name)
        {
            bool existDriver = context.Drivers.Any(x => x.FirstName.ToLower().Trim() == name.ToLower().Trim());
            return existDriver;
        }

        public IEnumerable<Driver> GetAllDrivers()
        {
            return context.Drivers;
        }
    }
}
