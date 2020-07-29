using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineEducation.Data.Migrations
{
    public partial class SeedVideoconference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Activities");

            migrationBuilder.AddColumn<string>(
                name: "RoomId",
                table: "Activities",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Activities");

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
