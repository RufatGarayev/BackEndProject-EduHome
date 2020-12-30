using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class SkillTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompletedPercent",
                table: "TeacherSkillSkill",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Percent",
                table: "TeacherSkillSkill",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletedPercent",
                table: "TeacherSkillSkill");

            migrationBuilder.DropColumn(
                name: "Percent",
                table: "TeacherSkillSkill");
        }
    }
}
