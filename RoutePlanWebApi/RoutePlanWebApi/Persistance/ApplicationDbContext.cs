using Microsoft.EntityFrameworkCore;
using RoutePlannerWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutePlanWebApi.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ApprovedRoutePlan> ApprovedRoutePlans { get; set; }
        public DbSet<WeatherCondition> WeatherConditions { get; set; }
        public DbSet<RoadCondition> RoadConditions { get; set; }

        public DbSet<Trailer> Trailers { get; set; }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<RoutePlanDetail> RoutePlanDetails { get; set; }
        public DbSet<AdditionalHazard> AdditionalHazards { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    }
}
