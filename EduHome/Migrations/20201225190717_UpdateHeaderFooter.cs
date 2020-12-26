using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class UpdateHeaderFooter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Bios");

            migrationBuilder.AddColumn<string>(
                name: "FooterLogo",
                table: "Bios",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HeaderLogo",
                table: "Bios",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FooterLogo",
                table: "Bios");

            migrationBuilder.DropColumn(
                name: "HeaderLogo",
                table: "Bios");

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "Bios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
