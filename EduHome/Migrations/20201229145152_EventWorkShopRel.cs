using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class EventWorkShopRel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "WorkShops");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "WorkShops");

            migrationBuilder.DropColumn(
                name: "TimeSpan",
                table: "WorkShops");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "WorkShops");

            migrationBuilder.DropColumn(
                name: "Venue",
                table: "WorkShops");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "WorkShops",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Venue",
                table: "Events",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeSpan",
                table: "Events",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkShops_EventId",
                table: "WorkShops",
                column: "EventId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkShops_Events_EventId",
                table: "WorkShops",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkShops_Events_EventId",
                table: "WorkShops");

            migrationBuilder.DropIndex(
                name: "IX_WorkShops_EventId",
                table: "WorkShops");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "WorkShops");

            migrationBuilder.DropColumn(
                name: "TimeSpan",
                table: "Events");

            migrationBuilder.AddColumn<DateTime>(
                name: "Day",
                table: "WorkShops",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "WorkShops",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeSpan",
                table: "WorkShops",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "WorkShops",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Venue",
                table: "WorkShops",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Venue",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "Events",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "Events",
                type: "datetime2",
                nullable: true);
        }
    }
}
