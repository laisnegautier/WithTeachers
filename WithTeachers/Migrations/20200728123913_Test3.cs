using Microsoft.EntityFrameworkCore.Migrations;

namespace WithTeachers.Migrations
{
    public partial class Test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Description", "Name", "UserId", "Year" },
                values: new object[,]
                {
                    { 1, null, "3A", null, 2013 },
                    { 2, null, "6B", null, 2015 },
                    { 3, null, "6C", null, 2011 },
                    { 4, null, "5D", null, 1984 },
                    { 5, null, "4A", null, 1700 }
                });
        }
    }
}
