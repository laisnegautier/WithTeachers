using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineEducation.Data.Migrations
{
    public partial class UpdatingName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 1,
                column: "ScheduledFor",
                value: new DateTime(2020, 7, 30, 7, 19, 10, 2, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 4,
                column: "ScheduledFor",
                value: new DateTime(2020, 7, 30, 7, 19, 10, 5, DateTimeKind.Local).AddTicks(4976));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 1,
                column: "ScheduledFor",
                value: new DateTime(2020, 7, 30, 7, 2, 44, 941, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 4,
                column: "ScheduledFor",
                value: new DateTime(2020, 7, 30, 7, 2, 44, 944, DateTimeKind.Local).AddTicks(7103));
        }
    }
}
