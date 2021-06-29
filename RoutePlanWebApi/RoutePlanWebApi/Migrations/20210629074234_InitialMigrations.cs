using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RoutePlanWebApi.Migrations
{
    public partial class InitialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalHazards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HazardName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalHazards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApprovedRoutePlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouteId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ParentRouteId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RouteStatus = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StatusReason = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecipientUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RecipientName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DatabaseName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DeviceId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateAproved = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateSentToDevice = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPlanSentToDevice = table.Column<bool>(type: "bit", nullable: false),
                    RoutePlanDetals = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoutePlanStopPointsHTML = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovedRoutePlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LineManager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenseExpiry = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoadConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConditionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoadConditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trailers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Registration = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trailers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Registration = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeatherConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConditionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherConditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DriverVehicle",
                columns: table => new
                {
                    DriversId = table.Column<int>(type: "int", nullable: false),
                    VehiclesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverVehicle", x => new { x.DriversId, x.VehiclesId });
                    table.ForeignKey(
                        name: "FK_DriverVehicle_Drivers_DriversId",
                        column: x => x.DriversId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DriverVehicle_Vehicles_VehiclesId",
                        column: x => x.VehiclesId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoutePlanDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVehicleFit = table.Column<bool>(type: "bit", nullable: false),
                    IsOverNightStay = table.Column<bool>(type: "bit", nullable: false),
                    IsVehicleInspected = table.Column<bool>(type: "bit", nullable: false),
                    IsRiskAssessed = table.Column<bool>(type: "bit", nullable: false),
                    IsPreIgnitionComplete = table.Column<bool>(type: "bit", nullable: false),
                    IsHazardIdentified = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedRoutePlanId = table.Column<int>(type: "int", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    TrailertId = table.Column<int>(type: "int", nullable: true),
                    TrailderId = table.Column<int>(type: "int", nullable: true),
                    WeatherConditionId = table.Column<int>(type: "int", nullable: false),
                    RoadConditionId = table.Column<int>(type: "int", nullable: false),
                    DriverId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoutePlanDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoutePlanDetails_ApprovedRoutePlans_ApprovedRoutePlanId",
                        column: x => x.ApprovedRoutePlanId,
                        principalTable: "ApprovedRoutePlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoutePlanDetails_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoutePlanDetails_RoadConditions_RoadConditionId",
                        column: x => x.RoadConditionId,
                        principalTable: "RoadConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoutePlanDetails_Trailers_TrailertId",
                        column: x => x.TrailertId,
                        principalTable: "Trailers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoutePlanDetails_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoutePlanDetails_WeatherConditions_WeatherConditionId",
                        column: x => x.WeatherConditionId,
                        principalTable: "WeatherConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalHazardRoutePlanDetail",
                columns: table => new
                {
                    AdditionalHazardsId = table.Column<int>(type: "int", nullable: false),
                    RoutePlanDetailsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalHazardRoutePlanDetail", x => new { x.AdditionalHazardsId, x.RoutePlanDetailsId });
                    table.ForeignKey(
                        name: "FK_AdditionalHazardRoutePlanDetail_AdditionalHazards_AdditionalHazardsId",
                        column: x => x.AdditionalHazardsId,
                        principalTable: "AdditionalHazards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdditionalHazardRoutePlanDetail_RoutePlanDetails_RoutePlanDetailsId",
                        column: x => x.RoutePlanDetailsId,
                        principalTable: "RoutePlanDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalHazardRoutePlanDetail_RoutePlanDetailsId",
                table: "AdditionalHazardRoutePlanDetail",
                column: "RoutePlanDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverVehicle_VehiclesId",
                table: "DriverVehicle",
                column: "VehiclesId");

            migrationBuilder.CreateIndex(
                name: "IX_RoutePlanDetails_ApprovedRoutePlanId",
                table: "RoutePlanDetails",
                column: "ApprovedRoutePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_RoutePlanDetails_DriverId",
                table: "RoutePlanDetails",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_RoutePlanDetails_RoadConditionId",
                table: "RoutePlanDetails",
                column: "RoadConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_RoutePlanDetails_TrailertId",
                table: "RoutePlanDetails",
                column: "TrailertId");

            migrationBuilder.CreateIndex(
                name: "IX_RoutePlanDetails_VehicleId",
                table: "RoutePlanDetails",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoutePlanDetails_WeatherConditionId",
                table: "RoutePlanDetails",
                column: "WeatherConditionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalHazardRoutePlanDetail");

            migrationBuilder.DropTable(
                name: "DriverVehicle");

            migrationBuilder.DropTable(
                name: "AdditionalHazards");

            migrationBuilder.DropTable(
                name: "RoutePlanDetails");

            migrationBuilder.DropTable(
                name: "ApprovedRoutePlans");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "RoadConditions");

            migrationBuilder.DropTable(
                name: "Trailers");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "WeatherConditions");
        }
    }
}
