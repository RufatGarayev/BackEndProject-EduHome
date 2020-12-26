using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class CreateTeachers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OurTeachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Position = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Pinterest = table.Column<string>(nullable: true),
                    Vimeo = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    TimeDeleted = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurTeachers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OurTeachers");
        }
    }
}
