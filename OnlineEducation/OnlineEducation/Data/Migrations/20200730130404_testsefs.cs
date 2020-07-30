using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineEducation.Data.Migrations
{
    public partial class testsefs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pseudo",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 1,
                column: "ScheduledFor",
                value: new DateTime(2020, 7, 30, 15, 4, 3, 497, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 4,
                column: "ScheduledFor",
                value: new DateTime(2020, 7, 30, 15, 4, 3, 502, DateTimeKind.Local).AddTicks(9900));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pseudo",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 1,
                column: "ScheduledFor",
                value: new DateTime(2020, 7, 30, 12, 19, 52, 678, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 4,
                column: "ScheduledFor",
                value: new DateTime(2020, 7, 30, 12, 19, 52, 681, DateTimeKind.Local).AddTicks(7023));
        }
    }
}
