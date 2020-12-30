using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class CreateTeacherSkillSkill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeacherSkillSkill",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OurTeacherId = table.Column<int>(nullable: false),
                    TeacherSkillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSkillSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherSkillSkill_OurTeachers_OurTeacherId",
                        column: x => x.OurTeacherId,
                        principalTable: "OurTeachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherSkillSkill_TeacherSkills_TeacherSkillId",
                        column: x => x.TeacherSkillId,
                        principalTable: "TeacherSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSkillSkill_OurTeacherId",
                table: "TeacherSkillSkill",
                column: "OurTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSkillSkill_TeacherSkillId",
                table: "TeacherSkillSkill",
                column: "TeacherSkillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherSkillSkill");
        }
    }
}
