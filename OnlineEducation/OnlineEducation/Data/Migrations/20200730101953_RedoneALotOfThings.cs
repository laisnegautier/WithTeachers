using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineEducation.Data.Migrations
{
    public partial class RedoneALotOfThings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Connections");

            migrationBuilder.DropTable(
                name: "UserRooms");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "VideoconferenceUsers");

            migrationBuilder.AddColumn<int>(
                name: "ActivityId",
                table: "VideoconferenceUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "VideoconferenceUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "VideoconferenceUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VideoconferenceActivityId",
                table: "VideoconferenceUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAnonymous",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SignalRConnections",
                columns: table => new
                {
                    SignalRConnectionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConnectionId = table.Column<string>(nullable: true),
                    UserAgent = table.Column<string>(nullable: true),
                    Connected = table.Column<bool>(nullable: false),
                    VideoconferenceUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignalRConnections", x => x.SignalRConnectionId);
                    table.ForeignKey(
                        name: "FK_SignalRConnections_VideoconferenceUsers_VideoconferenceUserId",
                        column: x => x.VideoconferenceUserId,
                        principalTable: "VideoconferenceUsers",
                        principalColumn: "VideoconferenceUserId",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_VideoconferenceUsers_UserId1",
                table: "VideoconferenceUsers",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_VideoconferenceUsers_VideoconferenceActivityId",
                table: "VideoconferenceUsers",
                column: "VideoconferenceActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalRConnections_VideoconferenceUserId",
                table: "SignalRConnections",
                column: "VideoconferenceUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VideoconferenceUsers_AspNetUsers_UserId1",
                table: "VideoconferenceUsers",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoconferenceUsers_Activities_VideoconferenceActivityId",
                table: "VideoconferenceUsers",
                column: "VideoconferenceActivityId",
                principalTable: "Activities",
                principalColumn: "ActivityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VideoconferenceUsers_AspNetUsers_UserId1",
                table: "VideoconferenceUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoconferenceUsers_Activities_VideoconferenceActivityId",
                table: "VideoconferenceUsers");

            migrationBuilder.DropTable(
                name: "SignalRConnections");

            migrationBuilder.DropIndex(
                name: "IX_VideoconferenceUsers_UserId1",
                table: "VideoconferenceUsers");

            migrationBuilder.DropIndex(
                name: "IX_VideoconferenceUsers_VideoconferenceActivityId",
                table: "VideoconferenceUsers");

            migrationBuilder.DropColumn(
                name: "ActivityId",
                table: "VideoconferenceUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "VideoconferenceUsers");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "VideoconferenceUsers");

            migrationBuilder.DropColumn(
                name: "VideoconferenceActivityId",
                table: "VideoconferenceUsers");

            migrationBuilder.DropColumn(
                name: "IsAnonymous",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "VideoconferenceUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Connections",
                columns: table => new
                {
                    ConnectionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Connected = table.Column<bool>(type: "bit", nullable: false),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoconferenceUserId = table.Column<int>(type: "int", nullable: true)
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
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                });

            migrationBuilder.CreateTable(
                name: "UserRooms",
                columns: table => new
                {
                    UserRoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    VideoconferenceUserId = table.Column<int>(type: "int", nullable: false)
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
                value: new DateTime(2020, 7, 30, 7, 19, 10, 2, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 4,
                column: "ScheduledFor",
                value: new DateTime(2020, 7, 30, 7, 19, 10, 5, DateTimeKind.Local).AddTicks(4976));

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
    }
}
