using RoutePlannerWebAPI.Models;
using RoutePlanWebApi.Persistance;
using RoutePlanWebApi.Repositories.Abstracts;
using RoutePlanWebApi.ViewModel;
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
        public Driver AddDrivers(DriverModel driver)
        {
            var section = context.Sections.Select(x => x.SectionName).ToString();
            var department = context.Departments.Select(x => x.DepartmentName).ToString();

            if (driver == null)
                throw new ArgumentException("Driver cannot be null");
            else if (DriverExist(driver.FirstName))
                throw new ArgumentException("The name already exist");


            var candidate = new Driver()
            {
                FirstName = driver.FirstName,
                PhoneNumber = driver.PhoneNumber,
                Email = driver.Email,
                Department = department,
                Section = section,
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

        public IEnumerable<Driver> GetAllDrivers()
        {
            return context.Drivers;
        }
    }
}
