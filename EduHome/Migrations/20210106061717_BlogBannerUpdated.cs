using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class BlogBannerUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogDetails_BlogBanners_BlogBannerId",
                table: "BlogDetails");

            migrationBuilder.DropIndex(
                name: "IX_BlogDetails_BlogBannerId",
                table: "BlogDetails");

            migrationBuilder.DropColumn(
                name: "BlogBannerId",
                table: "BlogDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogBannerId",
                table: "BlogDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BlogDetails_BlogBannerId",
                table: "BlogDetails",
                column: "BlogBannerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogDetails_BlogBanners_BlogBannerId",
                table: "BlogDetails",
                column: "BlogBannerId",
                principalTable: "BlogBanners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
