using Microsoft.EntityFrameworkCore;
using RoutePlanWebApi.Models;

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
        public DbSet<Department> Departments { get; set; }
        public DbSet<Section> Sections { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    }
}
