using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineEducation.Data.Migrations
{
    public partial class sdlkgnekrg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 1,
                column: "ScheduledFor",
                value: new DateTime(2020, 7, 30, 16, 1, 56, 173, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 4,
                column: "ScheduledFor",
                value: new DateTime(2020, 7, 30, 16, 1, 56, 182, DateTimeKind.Local).AddTicks(2777));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
