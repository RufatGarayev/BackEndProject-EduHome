using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class PostEventAndSoOnUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExplainingId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkSopId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "TimeSpan",
                table: "Events",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Day",
                table: "Events",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ExplainingId",
                table: "Posts",
                column: "ExplainingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_WorkSopId",
                table: "Posts",
                column: "WorkSopId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Explainings_ExplainingId",
                table: "Posts",
                column: "ExplainingId",
                principalTable: "Explainings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_WorkShops_WorkSopId",
                table: "Posts",
                column: "WorkSopId",
                principalTable: "WorkShops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Explainings_ExplainingId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_WorkShops_WorkSopId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_ExplainingId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_WorkSopId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ExplainingId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "WorkSopId",
                table: "Posts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeSpan",
                table: "Events",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Day",
                table: "Events",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
