using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class cwoAndcfRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "CourseFeatures");

            migrationBuilder.AddColumn<string>(
                name: "AboutCourse",
                table: "CourseFeatures",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Certification",
                table: "CourseFeatures",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CoursesWeOfferId",
                table: "CourseFeatures",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HowToApply",
                table: "CourseFeatures",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseFeatures_CoursesWeOfferId",
                table: "CourseFeatures",
                column: "CoursesWeOfferId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFeatures_CoursesWeOffers_CoursesWeOfferId",
                table: "CourseFeatures",
                column: "CoursesWeOfferId",
                principalTable: "CoursesWeOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseFeatures_CoursesWeOffers_CoursesWeOfferId",
                table: "CourseFeatures");

            migrationBuilder.DropIndex(
                name: "IX_CourseFeatures_CoursesWeOfferId",
                table: "CourseFeatures");

            migrationBuilder.DropColumn(
                name: "AboutCourse",
                table: "CourseFeatures");

            migrationBuilder.DropColumn(
                name: "Certification",
                table: "CourseFeatures");

            migrationBuilder.DropColumn(
                name: "CoursesWeOfferId",
                table: "CourseFeatures");

            migrationBuilder.DropColumn(
                name: "HowToApply",
                table: "CourseFeatures");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CourseFeatures",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
