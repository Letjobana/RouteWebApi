using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutePlanWebApi.Models
{
    public class AdditionalHazard
    {
        public int Id { get; set; }
        public string HazardName { get; set; }

        public ICollection<RoutePlanDetail> RoutePlanDetails { get; set; }
    }
}
