using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class TeacherAndBasicInfoRel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OurTeacherId",
                table: "TeacherBasicInfos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TeacherBasicInfos_OurTeacherId",
                table: "TeacherBasicInfos",
                column: "OurTeacherId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherBasicInfos_OurTeachers_OurTeacherId",
                table: "TeacherBasicInfos",
                column: "OurTeacherId",
                principalTable: "OurTeachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherBasicInfos_OurTeachers_OurTeacherId",
                table: "TeacherBasicInfos");

            migrationBuilder.DropIndex(
                name: "IX_TeacherBasicInfos_OurTeacherId",
                table: "TeacherBasicInfos");

            migrationBuilder.DropColumn(
                name: "OurTeacherId",
                table: "TeacherBasicInfos");
        }
    }
}
