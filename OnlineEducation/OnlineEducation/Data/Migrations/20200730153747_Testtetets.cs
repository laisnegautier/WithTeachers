using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineEducation.Data.Migrations
{
    public partial class Testtetets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VideoconferenceUsers_AspNetUsers_UserId1",
                table: "VideoconferenceUsers");

            migrationBuilder.DropIndex(
                name: "IX_VideoconferenceUsers_UserId1",
                table: "VideoconferenceUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "VideoconferenceUsers");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "VideoconferenceUsers");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "VideoconferenceUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 1,
                column: "ScheduledFor",
                value: new DateTime(2020, 7, 30, 17, 37, 46, 234, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 4,
                column: "ScheduledFor",
                value: new DateTime(2020, 7, 30, 17, 37, 46, 238, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.CreateIndex(
                name: "IX_VideoconferenceUsers_ApplicationUserId",
                table: "VideoconferenceUsers",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VideoconferenceUsers_AspNetUsers_ApplicationUserId",
                table: "VideoconferenceUsers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VideoconferenceUsers_AspNetUsers_ApplicationUserId",
                table: "VideoconferenceUsers");

            migrationBuilder.DropIndex(
                name: "IX_VideoconferenceUsers_ApplicationUserId",
                table: "VideoconferenceUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "VideoconferenceUsers");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "VideoconferenceUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "VideoconferenceUsers",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_VideoconferenceUsers_UserId1",
                table: "VideoconferenceUsers",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_VideoconferenceUsers_AspNetUsers_UserId1",
                table: "VideoconferenceUsers",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
