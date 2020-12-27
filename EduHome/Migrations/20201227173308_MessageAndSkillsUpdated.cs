using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class MessageAndSkillsUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "LeaveMessages");

            migrationBuilder.AddColumn<int>(
                name: "CompletedPercent",
                table: "TeacherSkills",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletedPercent",
                table: "TeacherSkills");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "LeaveMessages",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
