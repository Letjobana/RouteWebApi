﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoutePlanWebApi.Persistance;

namespace RoutePlanWebApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210630101433_Section")]
    partial class Section
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdditionalHazardRoutePlanDetail", b =>
                {
                    b.Property<int>("AdditionalHazardsId")
                        .HasColumnType("int");

                    b.Property<int>("RoutePlanDetailsId")
                        .HasColumnType("int");

                    b.HasKey("AdditionalHazardsId", "RoutePlanDetailsId");

                    b.HasIndex("RoutePlanDetailsId");

                    b.ToTable("AdditionalHazardRoutePlanDetail");
                });

            modelBuilder.Entity("DriverVehicle", b =>
                {
                    b.Property<int>("DriversId")
                        .HasColumnType("int");

                    b.Property<int>("VehiclesId")
                        .HasColumnType("int");

                    b.HasKey("DriversId", "VehiclesId");

                    b.HasIndex("VehiclesId");

                    b.ToTable("DriverVehicle");
                });

            modelBuilder.Entity("RoutePlanWebApi.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("RoutePlanWebApi.Models.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SectionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("RoutePlannerWebAPI.Models.AdditionalHazard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HazardName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AdditionalHazards");
                });

            modelBuilder.Entity("RoutePlannerWebAPI.Models.ApprovedRoutePlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DatabaseName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateAproved")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateSentToDevice")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeviceId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsPlanSentToDevice")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ParentRouteId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RecipientName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("RecipientUserId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RouteId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RoutePlanDetals")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoutePlanStopPointsHTML")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RouteStatus")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("StatusReason")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("ApprovedRoutePlans");
                });

            modelBuilder.Entity("RoutePlannerWebAPI.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LicenseExpiry")
                        .HasColumnType("datetime2");

                    b.Property<string>("LicenseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LineManager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("RoutePlannerWebAPI.Models.RoadCondition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConditionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoadConditions");
                });

            modelBuilder.Entity("RoutePlannerWebAPI.Models.RoutePlanDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApprovedRoutePlanId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<bool>("IsHazardIdentified")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOverNightStay")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPreIgnitionComplete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRiskAssessed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVehicleFit")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVehicleInspected")
                        .HasColumnType("bit");

                    b.Property<int>("RoadConditionId")
                        .HasColumnType("int");

                    b.Property<int?>("TrailderId")
                        .HasColumnType("int");

                    b.Property<int?>("TrailertId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.Property<int>("WeatherConditionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApprovedRoutePlanId");

                    b.HasIndex("DriverId");

                    b.HasIndex("RoadConditionId");

                    b.HasIndex("TrailertId");

                    b.HasIndex("VehicleId");

                    b.HasIndex("WeatherConditionId");

                    b.ToTable("RoutePlanDetails");
                });

            modelBuilder.Entity("RoutePlannerWebAPI.Models.Trailer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Registration")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trailers");
                });

            modelBuilder.Entity("RoutePlannerWebAPI.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Registration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("RoutePlannerWebAPI.Models.WeatherCondition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConditionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WeatherConditions");
                });

            modelBuilder.Entity("AdditionalHazardRoutePlanDetail", b =>
                {
                    b.HasOne("RoutePlannerWebAPI.Models.AdditionalHazard", null)
                        .WithMany()
                        .HasForeignKey("AdditionalHazardsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RoutePlannerWebAPI.Models.RoutePlanDetail", null)
                        .WithMany()
                        .HasForeignKey("RoutePlanDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DriverVehicle", b =>
                {
                    b.HasOne("RoutePlannerWebAPI.Models.Driver", null)
                        .WithMany()
                        .HasForeignKey("DriversId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RoutePlannerWebAPI.Models.Vehicle", null)
                        .WithMany()
                        .HasForeignKey("VehiclesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoutePlannerWebAPI.Models.RoutePlanDetail", b =>
                {
                    b.HasOne("RoutePlannerWebAPI.Models.ApprovedRoutePlan", "ApprovedRoutePlans")
                        .WithMany()
                        .HasForeignKey("ApprovedRoutePlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RoutePlannerWebAPI.Models.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RoutePlannerWebAPI.Models.RoadCondition", "RoadCondition")
                        .WithMany()
                        .HasForeignKey("RoadConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RoutePlannerWebAPI.Models.Trailer", "Trailert")
                        .WithMany()
                        .HasForeignKey("TrailertId");

                    b.HasOne("RoutePlannerWebAPI.Models.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RoutePlannerWebAPI.Models.WeatherCondition", "WeatherCondition")
                        .WithMany()
                        .HasForeignKey("WeatherConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApprovedRoutePlans");

                    b.Navigation("Driver");

                    b.Navigation("RoadCondition");

                    b.Navigation("Trailert");

                    b.Navigation("Vehicle");

                    b.Navigation("WeatherCondition");
                });
#pragma warning restore 612, 618
        }
    }
}