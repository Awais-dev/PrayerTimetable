using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrayerTimes.Data.Migrations
{
    public partial class updateforjson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "PrayerTimetable");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "PrayerTimetable");

            migrationBuilder.DropColumn(
                name: "Sunrise",
                table: "PrayerTimetable");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Day",
                table: "PrayerTimetable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Month",
                table: "PrayerTimetable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Sunrise",
                table: "PrayerTimetable",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
