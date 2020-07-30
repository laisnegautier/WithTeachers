using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineEducation.Data.Migrations
{
    public partial class Testtetets4sd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VideoconferenceUsers_Activities_VideoconferenceActivityId",
                table: "VideoconferenceUsers");

            migrationBuilder.AlterColumn<int>(
                name: "VideoconferenceActivityId",
                table: "VideoconferenceUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 1,
                column: "ScheduledFor",
                value: new DateTime(2020, 7, 30, 18, 5, 51, 13, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 4,
                column: "ScheduledFor",
                value: new DateTime(2020, 7, 30, 18, 5, 51, 17, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.AddForeignKey(
                name: "FK_VideoconferenceUsers_Activities_VideoconferenceActivityId",
                table: "VideoconferenceUsers",
                column: "VideoconferenceActivityId",
                principalTable: "Activities",
                principalColumn: "ActivityId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VideoconferenceUsers_Activities_VideoconferenceActivityId",
                table: "VideoconferenceUsers");

            migrationBuilder.AlterColumn<int>(
                name: "VideoconferenceActivityId",
                table: "VideoconferenceUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 1,
                column: "ScheduledFor",
                value: new DateTime(2020, 7, 30, 17, 39, 56, 427, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 4,
                column: "ScheduledFor",
                value: new DateTime(2020, 7, 30, 17, 39, 56, 430, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.AddForeignKey(
                name: "FK_VideoconferenceUsers_Activities_VideoconferenceActivityId",
                table: "VideoconferenceUsers",
                column: "VideoconferenceActivityId",
                principalTable: "Activities",
                principalColumn: "ActivityId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
