using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutePlannerWebAPI.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string VehicleType { get; set; }

        public string? Registration { get; set; }

        public ICollection<Driver> Drivers { get; set; }
    }
}
