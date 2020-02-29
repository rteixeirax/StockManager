using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManager.Storage.Migrations
{
    public partial class SeedInitialValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Code", "CreatedAt", "UpdatedAt" },
                values: new object[] { 1, "Admin", new DateTime(2020, 1, 12, 21, 42, 13, 141, DateTimeKind.Utc).AddTicks(230), new DateTime(2020, 1, 12, 21, 42, 13, 141, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Code", "CreatedAt", "UpdatedAt" },
                values: new object[] { 2, "User", new DateTime(2020, 1, 12, 21, 42, 13, 141, DateTimeKind.Utc).AddTicks(230), new DateTime(2020, 1, 12, 21, 42, 13, 141, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "LastLogin", "Password", "RoleId", "UpdatedAt", "Username" },
                values: new object[] { 1, new DateTime(2020, 1, 12, 21, 42, 13, 238, DateTimeKind.Utc).AddTicks(9795), null, "$2b$10$eGGf5hvPB.DFTm5c1CkMS..tESLBS1ny7Jf06Y6UiKaOULQAXGQjK", 1, new DateTime(2020, 1, 12, 21, 42, 13, 238, DateTimeKind.Utc).AddTicks(9795), "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1);
        }
    }
}
