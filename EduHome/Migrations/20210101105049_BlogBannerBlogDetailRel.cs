using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class BlogBannerBlogDetailRel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogBannerId",
                table: "BlogDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "WorkShopSpeakers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkShopId = table.Column<int>(nullable: false),
                    SpeakerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkShopSpeakers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkShopSpeakers_Speakers_SpeakerId",
                        column: x => x.SpeakerId,
                        principalTable: "Speakers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkShopSpeakers_WorkShops_WorkShopId",
                        column: x => x.WorkShopId,
                        principalTable: "WorkShops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogDetails_BlogBannerId",
                table: "BlogDetails",
                column: "BlogBannerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkShopSpeakers_SpeakerId",
                table: "WorkShopSpeakers",
                column: "SpeakerId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkShopSpeakers_WorkShopId",
                table: "WorkShopSpeakers",
                column: "WorkShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogDetails_BlogBanners_BlogBannerId",
                table: "BlogDetails",
                column: "BlogBannerId",
                principalTable: "BlogBanners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogDetails_BlogBanners_BlogBannerId",
                table: "BlogDetails");

            migrationBuilder.DropTable(
                name: "WorkShopSpeakers");

            migrationBuilder.DropIndex(
                name: "IX_BlogDetails_BlogBannerId",
                table: "BlogDetails");

            migrationBuilder.DropColumn(
                name: "BlogBannerId",
                table: "BlogDetails");
        }
    }
}
