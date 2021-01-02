using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrayerTimes.Data.Migrations
{
    public partial class updateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrayerTimetable_Prayer_AsrId",
                table: "PrayerTimetable");

            migrationBuilder.DropForeignKey(
                name: "FK_PrayerTimetable_Prayer_DhuhrId",
                table: "PrayerTimetable");

            migrationBuilder.DropForeignKey(
                name: "FK_PrayerTimetable_Prayer_FajrId",
                table: "PrayerTimetable");

            migrationBuilder.DropForeignKey(
                name: "FK_PrayerTimetable_Prayer_IshaId",
                table: "PrayerTimetable");

            migrationBuilder.DropForeignKey(
                name: "FK_PrayerTimetable_Prayer_MaghribId",
                table: "PrayerTimetable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrayerTimetable",
                table: "PrayerTimetable");

            migrationBuilder.DropIndex(
                name: "IX_PrayerTimetable_AsrId",
                table: "PrayerTimetable");

            migrationBuilder.DropIndex(
                name: "IX_PrayerTimetable_DhuhrId",
                table: "PrayerTimetable");

            migrationBuilder.DropIndex(
                name: "IX_PrayerTimetable_FajrId",
                table: "PrayerTimetable");

            migrationBuilder.DropIndex(
                name: "IX_PrayerTimetable_IshaId",
                table: "PrayerTimetable");

            migrationBuilder.DropIndex(
                name: "IX_PrayerTimetable_MaghribId",
                table: "PrayerTimetable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prayer",
                table: "Prayer");

            migrationBuilder.DropColumn(
                name: "AsrId",
                table: "PrayerTimetable");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "PrayerTimetable");

            migrationBuilder.DropColumn(
                name: "DhuhrId",
                table: "PrayerTimetable");

            migrationBuilder.DropColumn(
                name: "FajrId",
                table: "PrayerTimetable");

            migrationBuilder.DropColumn(
                name: "IshaId",
                table: "PrayerTimetable");

            migrationBuilder.DropColumn(
                name: "MaghribId",
                table: "PrayerTimetable");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "PrayerTimetable");

            migrationBuilder.DropColumn(
                name: "Sunrise",
                table: "PrayerTimetable");

            migrationBuilder.DropColumn(
                name: "Jamat",
                table: "Prayer");

            migrationBuilder.RenameTable(
                name: "PrayerTimetable",
                newName: "PrayerTimetables");

            migrationBuilder.RenameTable(
                name: "Prayer",
                newName: "Prayers");

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "PrayerTimetables",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Start",
                table: "Prayers",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "PrayerName",
                table: "Prayers",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PrayerTimetableId",
                table: "Prayers",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrayerTimetables",
                table: "PrayerTimetables",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prayers",
                table: "Prayers",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Prayers_PrayerTimetableId",
                table: "Prayers",
                column: "PrayerTimetableId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prayers_PrayerTimetables_PrayerTimetableId",
                table: "Prayers",
                column: "PrayerTimetableId",
                principalTable: "PrayerTimetables",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prayers_PrayerTimetables_PrayerTimetableId",
                table: "Prayers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrayerTimetables",
                table: "PrayerTimetables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prayers",
                table: "Prayers");

            migrationBuilder.DropIndex(
                name: "IX_Prayers_PrayerTimetableId",
                table: "Prayers");

            migrationBuilder.DropColumn(
                name: "PrayerName",
                table: "Prayers");

            migrationBuilder.DropColumn(
                name: "PrayerTimetableId",
                table: "Prayers");

            migrationBuilder.RenameTable(
                name: "PrayerTimetables",
                newName: "PrayerTimetable");

            migrationBuilder.RenameTable(
                name: "Prayers",
                newName: "Prayer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "PrayerTimetable",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AsrId",
                table: "PrayerTimetable",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day",
                table: "PrayerTimetable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DhuhrId",
                table: "PrayerTimetable",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FajrId",
                table: "PrayerTimetable",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IshaId",
                table: "PrayerTimetable",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MaghribId",
                table: "PrayerTimetable",
                type: "uniqueidentifier",
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "Start",
                table: "Prayer",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<DateTime>(
                name: "Jamat",
                table: "Prayer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrayerTimetable",
                table: "PrayerTimetable",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prayer",
                table: "Prayer",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_PrayerTimetable_AsrId",
                table: "PrayerTimetable",
                column: "AsrId");

            migrationBuilder.CreateIndex(
                name: "IX_PrayerTimetable_DhuhrId",
                table: "PrayerTimetable",
                column: "DhuhrId");

            migrationBuilder.CreateIndex(
                name: "IX_PrayerTimetable_FajrId",
                table: "PrayerTimetable",
                column: "FajrId");

            migrationBuilder.CreateIndex(
                name: "IX_PrayerTimetable_IshaId",
                table: "PrayerTimetable",
                column: "IshaId");

            migrationBuilder.CreateIndex(
                name: "IX_PrayerTimetable_MaghribId",
                table: "PrayerTimetable",
                column: "MaghribId");

            migrationBuilder.AddForeignKey(
                name: "FK_PrayerTimetable_Prayer_AsrId",
                table: "PrayerTimetable",
                column: "AsrId",
                principalTable: "Prayer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrayerTimetable_Prayer_DhuhrId",
                table: "PrayerTimetable",
                column: "DhuhrId",
                principalTable: "Prayer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrayerTimetable_Prayer_FajrId",
                table: "PrayerTimetable",
                column: "FajrId",
                principalTable: "Prayer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrayerTimetable_Prayer_IshaId",
                table: "PrayerTimetable",
                column: "IshaId",
                principalTable: "Prayer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrayerTimetable_Prayer_MaghribId",
                table: "PrayerTimetable",
                column: "MaghribId",
                principalTable: "Prayer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
