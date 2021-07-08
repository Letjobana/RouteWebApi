
using RoutePlanWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutePlanWebApi.Models
{
    public class RoutePlanDetail
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsVehicleFit { get; set; }
        public bool IsOverNightStay { get; set; }
        public bool IsVehicleInspected { get; set; }
        public bool IsRiskAssessed { get; set; }
        public bool IsPreIgnitionComplete { get; set; }
        public bool IsHazardIdentified { get; set; }

        public ApprovedRoutePlan ApprovedRoutePlans { get; set; }

        public int ApprovedRoutePlanId { get; set; }

        public Vehicle Vehicle { get; set; }
        public int VehicleId { get; set; }

        public Trailer? Trailert { get; set; }
        public int? TrailderId { get; set; }
        public WeatherCondition WeatherCondition { get; set; }
        public int WeatherConditionId { get; set; }
        public RoadCondition RoadCondition { get; set; }
        public int RoadConditionId { get; set; }
        public Driver Driver { get; set; }
        public int DriverId { get; set; }

        public ICollection<AdditionalHazard> AdditionalHazards { get; set; }
    }
}
