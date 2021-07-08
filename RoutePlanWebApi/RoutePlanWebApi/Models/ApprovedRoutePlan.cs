using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoutePlanWebApi.Models
{
    public class ApprovedRoutePlan
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string RouteId { get; set; }
        [Required]
        [MaxLength(50)]
        public string ParentRouteId { get; set; }
        [Required]
        [MaxLength(10)]
        public string RouteStatus { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }
        [Required]
        [MaxLength(150)]
        public string StatusReason { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        [Required]
        [MaxLength(50)]
        public string RecipientUserId { get; set; }
        [Required]
        [MaxLength(60)]
        public string RecipientName { get; set; }
        [Required]
        [MaxLength(50)]
        public string DatabaseName { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string DeviceId { get; set; }
        public DateTime? DateAproved { get; set; }
        public DateTime? DateSentToDevice { get; set; }
        [Required]
        public bool IsPlanSentToDevice { get; set; }
        public string RoutePlanDetals { get; set; }
        public string RoutePlanStopPointsHTML { get; set; }
    }
}
