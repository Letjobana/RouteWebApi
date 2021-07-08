using RoutePlanWebApi.Models;
using RoutePlanWebApi.Persistance;
using RoutePlanWebApi.Repositories.Abstracts;
using RoutePlanWebApi.ViewModel;
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
        public Driver AddDrivers(DriverModel driver)
        {



            var candidate = new Driver()
            {
                FirstName = driver.FirstName,
                PhoneNumber = driver.PhoneNumber,
                Email = driver.Email,
                Department = driver.Department,
                Section = driver.Section,
                LineManager = driver.LicenseNumber,
                LicenseNumber = driver.LicenseNumber,
                LicenseExpiry = driver.LicenseExpiry

            };

            context.Drivers.Add(candidate);
            context.SaveChanges();
            return candidate;
        }

        public bool DriverExist(string name)
        {
            bool existDriver = context.Drivers.Any(x => x.FirstName.ToLower().Trim() == name.ToLower().Trim());
            return existDriver;
        }

        public IEnumerable<Department> GetAllDepartment()
        {
            return context.Departments;
        }
        public IEnumerable<Section> GetAllSection()
        {
            return context.Sections; ;
        }


        public IEnumerable<Driver> GetAllDrivers()
        {
            return context.Drivers;
        }
    }
}
