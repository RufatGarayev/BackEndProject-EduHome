using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class CourseAndAddressRel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CoursesWeOfferId",
                table: "Addresses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CoursesWeOfferId",
                table: "Addresses",
                column: "CoursesWeOfferId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_CoursesWeOffers_CoursesWeOfferId",
                table: "Addresses",
                column: "CoursesWeOfferId",
                principalTable: "CoursesWeOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_CoursesWeOffers_CoursesWeOfferId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_CoursesWeOfferId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "CoursesWeOfferId",
                table: "Addresses");
        }
    }
}
