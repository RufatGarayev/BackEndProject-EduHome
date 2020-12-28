using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class SomeChangesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoursesTexts");

            migrationBuilder.DropColumn(
                name: "CompletedPercent",
                table: "TeacherSkills");

            migrationBuilder.DropColumn(
                name: "Percent",
                table: "TeacherSkills");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CourseFeatures",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "CourseFeatures",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "CourseFeatures");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "CourseFeatures");

            migrationBuilder.AddColumn<string>(
                name: "CompletedPercent",
                table: "TeacherSkills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Percent",
                table: "TeacherSkills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CoursesTexts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TimeDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesTexts", x => x.Id);
                });
        }
    }
}
