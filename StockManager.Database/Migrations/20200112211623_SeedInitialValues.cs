using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManager.Database.Migrations
{
    public partial class SeedInitialValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Code", "CreatedAt", "UpdatedAt" },
                values: new object[] { 1, "Admin", new DateTime(2020, 1, 12, 21, 16, 22, 330, DateTimeKind.Utc).AddTicks(5897), null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Code", "CreatedAt", "UpdatedAt" },
                values: new object[] { 2, "User", new DateTime(2020, 1, 12, 21, 16, 22, 330, DateTimeKind.Utc).AddTicks(5897), null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "LastLogin", "Password", "RoleId", "UpdatedAt", "Username" },
                values: new object[] { 1, new DateTime(2020, 1, 12, 21, 16, 22, 436, DateTimeKind.Utc).AddTicks(5282), null, "$2b$10$8gdHDF.HUVrM3v4w/WoaMu4NULDzydzWh2sTrSbWiHuM3DkKP3Yla", 1, null, "Admin" });
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
