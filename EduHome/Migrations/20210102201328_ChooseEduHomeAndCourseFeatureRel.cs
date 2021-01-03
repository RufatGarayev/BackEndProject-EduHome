using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class ChooseEduHomeAndCourseFeatureRel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Fullname",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "CourseFeatureChooseEduHome",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseFeatureId = table.Column<int>(nullable: false),
                    ChooseEduHomeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseFeatureChooseEduHome", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseFeatureChooseEduHome_ChooseEduHomes_ChooseEduHomeId",
                        column: x => x.ChooseEduHomeId,
                        principalTable: "ChooseEduHomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseFeatureChooseEduHome_CourseFeatures_CourseFeatureId",
                        column: x => x.CourseFeatureId,
                        principalTable: "CourseFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseFeatureChooseEduHome_ChooseEduHomeId",
                table: "CourseFeatureChooseEduHome",
                column: "ChooseEduHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFeatureChooseEduHome_CourseFeatureId",
                table: "CourseFeatureChooseEduHome",
                column: "CourseFeatureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseFeatureChooseEduHome");

            migrationBuilder.DropColumn(
                name: "Fullname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");
        }
    }
}
