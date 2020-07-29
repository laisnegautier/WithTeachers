using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineEducation.Data.Migrations
{
    public partial class updateactivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Completed",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Ongoing",
                table: "Activities");

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Activities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsOngoing",
                table: "Activities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ActivityId", "CreationDate", "Description", "Discriminator", "IsCompleted", "IsOngoing", "ScheduledFor", "TimeSpan", "Title", "UserId", "Password", "RoomId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 3, 24, 4, 45, 19, 0, DateTimeKind.Unspecified), "You have to follow now", "Videoconference", false, true, new DateTime(2020, 7, 29, 10, 58, 28, 831, DateTimeKind.Local).AddTicks(3940), new TimeSpan(0, 2, 30, 0, 0), "Course of Mathematics", "5925d79e-5ed1-4e19-ae1f-8ef0e4474cad", "SOIT", "course-of-mathXBZ" },
                    { 2, new DateTime(2019, 3, 24, 4, 45, 19, 0, DateTimeKind.Unspecified), "Goodbye Ornald", "Videoconference", true, false, new DateTime(2020, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0), "Video already passed", "5925d79e-5ed1-4e19-ae1f-8ef0e4474cad", "4XUBG", "this-is-me" },
                    { 3, new DateTime(2018, 3, 24, 4, 45, 19, 0, DateTimeKind.Unspecified), "Hy Iceland", "Videoconference", false, false, new DateTime(2020, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 0, 0, 0), "Video to come", "5925d79e-5ed1-4e19-ae1f-8ef0e4474cad", "YEAH", "to-come" },
                    { 4, new DateTime(2020, 3, 24, 4, 45, 19, 0, DateTimeKind.Unspecified), "You", "Videoconference", false, true, new DateTime(2020, 7, 29, 10, 58, 28, 834, DateTimeKind.Local).AddTicks(6603), new TimeSpan(0, 0, 30, 0, 0), "Without Password", "5925d79e-5ed1-4e19-ae1f-8ef0e4474cad", null, "without-password" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "IsOngoing",
                table: "Activities");

            migrationBuilder.AddColumn<bool>(
                name: "Completed",
                table: "Activities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ongoing",
                table: "Activities",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
