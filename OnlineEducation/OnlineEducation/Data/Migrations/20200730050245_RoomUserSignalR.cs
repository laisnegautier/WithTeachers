using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineEducation.Data.Migrations
{
    public partial class RoomUserSignalR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                });

            migrationBuilder.CreateTable(
                name: "VideoconferenceUsers",
                columns: table => new
                {
                    VideoconferenceUserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoconferenceUsers", x => x.VideoconferenceUserId);
                });

            migrationBuilder.CreateTable(
                name: "Connections",
                columns: table => new
                {
                    ConnectionId = table.Column<string>(nullable: false),
                    UserAgent = table.Column<string>(nullable: true),
                    Connected = table.Column<bool>(nullable: false),
                    VideoconferenceUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Connections", x => x.ConnectionId);
                    table.ForeignKey(
                        name: "FK_Connections_VideoconferenceUsers_VideoconferenceUserId",
                        column: x => x.VideoconferenceUserId,
                        principalTable: "VideoconferenceUsers",
                        principalColumn: "VideoconferenceUserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRooms",
                columns: table => new
                {
                    UserRoomId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoconferenceUserId = table.Column<int>(nullable: false),
                    RoomId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRooms", x => x.UserRoomId);
                    table.ForeignKey(
                        name: "FK_UserRooms_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRooms_VideoconferenceUsers_VideoconferenceUserId",
                        column: x => x.VideoconferenceUserId,
                        principalTable: "VideoconferenceUsers",
                        principalColumn: "VideoconferenceUserId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Connections_VideoconferenceUserId",
                table: "Connections",
                column: "VideoconferenceUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRooms_RoomId",
                table: "UserRooms",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRooms_VideoconferenceUserId",
                table: "UserRooms",
                column: "VideoconferenceUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Connections");

            migrationBuilder.DropTable(
                name: "UserRooms");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "VideoconferenceUsers");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 1,
                column: "ScheduledFor",
                value: new DateTime(2020, 7, 29, 11, 35, 7, 673, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 4,
                column: "ScheduledFor",
                value: new DateTime(2020, 7, 29, 11, 35, 7, 680, DateTimeKind.Local).AddTicks(9163));
        }
    }
}
