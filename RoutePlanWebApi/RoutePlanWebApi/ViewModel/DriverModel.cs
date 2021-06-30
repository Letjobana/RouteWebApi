using System;

namespace RoutePlanWebApi.ViewModel
{
    public class DriverModel
    {
        
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string Section { get; set; }

        public string LineManager { get; set; }

        public string LicenseNumber { get; set; }
        public DateTime LicenseExpiry { get; set; }
    }
}
