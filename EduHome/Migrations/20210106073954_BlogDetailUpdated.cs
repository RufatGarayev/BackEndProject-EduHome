using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class BlogDetailUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Explainings_ExplainingId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "Explainings");

            migrationBuilder.DropIndex(
                name: "IX_Posts_ExplainingId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ExplainingId",
                table: "Posts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExplainingId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Explainings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Composer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TimeDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Explainings", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ExplainingId",
                table: "Posts",
                column: "ExplainingId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Explainings_ExplainingId",
                table: "Posts",
                column: "ExplainingId",
                principalTable: "Explainings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
