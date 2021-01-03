using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class UpcomingEventUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "UpcomingEvents");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "UpcomingEvents");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "UpcomingEvents",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Day",
                table: "UpcomingEvents",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TimeSpan",
                table: "UpcomingEvents",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeSpan",
                table: "UpcomingEvents");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "UpcomingEvents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Day",
                table: "UpcomingEvents",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "UpcomingEvents",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "UpcomingEvents",
                type: "datetime2",
                nullable: true);
        }
    }
}
