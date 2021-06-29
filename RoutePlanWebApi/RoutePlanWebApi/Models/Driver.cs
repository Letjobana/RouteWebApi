using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutePlannerWebAPI.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string Section { get; set; }

        public string LineManager { get; set; }

        public string LicenseNumber { get; set; }
        public DateTime LicenseExpiry { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }

    }
}
