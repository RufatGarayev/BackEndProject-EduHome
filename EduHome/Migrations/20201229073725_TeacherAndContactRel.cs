using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class TeacherAndContactRel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OurTeacherId",
                table: "TeacherContactInfos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TeacherContactInfos_OurTeacherId",
                table: "TeacherContactInfos",
                column: "OurTeacherId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherContactInfos_OurTeachers_OurTeacherId",
                table: "TeacherContactInfos",
                column: "OurTeacherId",
                principalTable: "OurTeachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherContactInfos_OurTeachers_OurTeacherId",
                table: "TeacherContactInfos");

            migrationBuilder.DropIndex(
                name: "IX_TeacherContactInfos_OurTeacherId",
                table: "TeacherContactInfos");

            migrationBuilder.DropColumn(
                name: "OurTeacherId",
                table: "TeacherContactInfos");
        }
    }
}
