using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStore.Data.Migrations
{
    public partial class SeedGameGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GameGroups",
                columns: new[] { "Id", "CreateDate", "Title" },
                values: new object[] { 1, new DateTime(2021, 10, 10, 19, 28, 0, 0, DateTimeKind.Unspecified), "Action" });

            migrationBuilder.InsertData(
                table: "GameGroups",
                columns: new[] { "Id", "CreateDate", "Title" },
                values: new object[] { 2, new DateTime(2021, 10, 10, 19, 28, 0, 0, DateTimeKind.Unspecified), "Adventure" });

            migrationBuilder.InsertData(
                table: "GameGroups",
                columns: new[] { "Id", "CreateDate", "Title" },
                values: new object[] { 3, new DateTime(2021, 10, 10, 19, 28, 0, 0, DateTimeKind.Unspecified), "Racing" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameGroups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GameGroups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GameGroups",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
