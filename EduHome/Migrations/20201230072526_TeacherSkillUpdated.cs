using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class TeacherSkillUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherSkillSkill_OurTeachers_OurTeacherId",
                table: "TeacherSkillSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherSkillSkill_TeacherSkills_TeacherSkillId",
                table: "TeacherSkillSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeacherSkillSkill",
                table: "TeacherSkillSkill");

            migrationBuilder.DropColumn(
                name: "CompletedPercent",
                table: "TeacherSkillSkill");

            migrationBuilder.DropColumn(
                name: "Percent",
                table: "TeacherSkillSkill");

            migrationBuilder.RenameTable(
                name: "TeacherSkillSkill",
                newName: "TeacherSkillSkills");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherSkillSkill_TeacherSkillId",
                table: "TeacherSkillSkills",
                newName: "IX_TeacherSkillSkills_TeacherSkillId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherSkillSkill_OurTeacherId",
                table: "TeacherSkillSkills",
                newName: "IX_TeacherSkillSkills_OurTeacherId");

            migrationBuilder.AddColumn<string>(
                name: "CompletedPercent",
                table: "TeacherSkills",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Percent",
                table: "TeacherSkills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeacherSkillSkills",
                table: "TeacherSkillSkills",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherSkillSkills_OurTeachers_OurTeacherId",
                table: "TeacherSkillSkills",
                column: "OurTeacherId",
                principalTable: "OurTeachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherSkillSkills_TeacherSkills_TeacherSkillId",
                table: "TeacherSkillSkills",
                column: "TeacherSkillId",
                principalTable: "TeacherSkills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherSkillSkills_OurTeachers_OurTeacherId",
                table: "TeacherSkillSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherSkillSkills_TeacherSkills_TeacherSkillId",
                table: "TeacherSkillSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeacherSkillSkills",
                table: "TeacherSkillSkills");

            migrationBuilder.DropColumn(
                name: "CompletedPercent",
                table: "TeacherSkills");

            migrationBuilder.DropColumn(
                name: "Percent",
                table: "TeacherSkills");

            migrationBuilder.RenameTable(
                name: "TeacherSkillSkills",
                newName: "TeacherSkillSkill");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherSkillSkills_TeacherSkillId",
                table: "TeacherSkillSkill",
                newName: "IX_TeacherSkillSkill_TeacherSkillId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherSkillSkills_OurTeacherId",
                table: "TeacherSkillSkill",
                newName: "IX_TeacherSkillSkill_OurTeacherId");

            migrationBuilder.AddColumn<string>(
                name: "CompletedPercent",
                table: "TeacherSkillSkill",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Percent",
                table: "TeacherSkillSkill",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeacherSkillSkill",
                table: "TeacherSkillSkill",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherSkillSkill_OurTeachers_OurTeacherId",
                table: "TeacherSkillSkill",
                column: "OurTeacherId",
                principalTable: "OurTeachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherSkillSkill_TeacherSkills_TeacherSkillId",
                table: "TeacherSkillSkill",
                column: "TeacherSkillId",
                principalTable: "TeacherSkills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
