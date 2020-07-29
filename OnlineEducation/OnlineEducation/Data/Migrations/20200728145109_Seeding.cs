using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineEducation.Data.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ActivityId", "Completed", "CreationDate", "Description", "Discriminator", "Ongoing", "ScheduledFor", "TimeSpan", "Title", "UserId", "Password", "RoomId" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2020, 3, 24, 4, 45, 19, 0, DateTimeKind.Unspecified), "You have to follow now", "Videoconference", true, new DateTime(2020, 7, 28, 16, 51, 7, 981, DateTimeKind.Local).AddTicks(9997), new TimeSpan(0, 2, 30, 0, 0), "Course of Mathematics", "5925d79e-5ed1-4e19-ae1f-8ef0e4474cad", "SOIT", "course-of-mathXBZ" },
                    { 2, true, new DateTime(2019, 3, 24, 4, 45, 19, 0, DateTimeKind.Unspecified), "Goodbye Ornald", "Videoconference", false, new DateTime(2020, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0), "Video already passed", "5925d79e-5ed1-4e19-ae1f-8ef0e4474cad", "4XUBG", "this-is-me" },
                    { 3, false, new DateTime(2018, 3, 24, 4, 45, 19, 0, DateTimeKind.Unspecified), "Hy Iceland", "Videoconference", false, new DateTime(2020, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 0, 0, 0), "Video to come", "5925d79e-5ed1-4e19-ae1f-8ef0e4474cad", "YEAH", "to-come" },
                    { 4, false, new DateTime(2020, 3, 24, 4, 45, 19, 0, DateTimeKind.Unspecified), "You", "Videoconference", true, new DateTime(2020, 7, 28, 16, 51, 7, 988, DateTimeKind.Local).AddTicks(3541), new TimeSpan(0, 0, 30, 0, 0), "Without Password", "5925d79e-5ed1-4e19-ae1f-8ef0e4474cad", null, "without-password" }
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
        }
    }
}
