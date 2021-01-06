using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class SubscribeUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Subscribes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Subscribes");

            migrationBuilder.DropColumn(
                name: "TimeDeleted",
                table: "Subscribes");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Subscribes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Subscribes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SubscribedEmails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    TimeDeleted = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscribedEmails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubscribedEmails");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Subscribes");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Subscribes");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Subscribes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Subscribes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeDeleted",
                table: "Subscribes",
                type: "datetime2",
                nullable: true);
        }
    }
}
