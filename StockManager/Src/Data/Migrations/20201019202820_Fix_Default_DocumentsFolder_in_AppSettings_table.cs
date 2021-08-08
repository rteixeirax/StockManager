using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManager.Src.Data.Migrations
{
    public partial class Fix_Default_DocumentsFolder_in_AppSettings_table : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppSettings",
                keyColumn: "AppSettingsId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DocumentsFolder", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 23, 19, 27, 42, 437, DateTimeKind.Utc).AddTicks(3222), "Desktop", new DateTime(2020, 9, 23, 19, 27, 42, 438, DateTimeKind.Utc).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsMain", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 23, 19, 27, 42, 481, DateTimeKind.Utc).AddTicks(2970), true, new DateTime(2020, 9, 23, 19, 27, 42, 481, DateTimeKind.Utc).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 23, 19, 27, 42, 481, DateTimeKind.Utc).AddTicks(2970), new DateTime(2020, 9, 23, 19, 27, 42, 481, DateTimeKind.Utc).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 23, 19, 27, 42, 489, DateTimeKind.Utc).AddTicks(2925), new DateTime(2020, 9, 23, 19, 27, 42, 489, DateTimeKind.Utc).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 23, 19, 27, 42, 489, DateTimeKind.Utc).AddTicks(2925), new DateTime(2020, 9, 23, 19, 27, 42, 489, DateTimeKind.Utc).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 23, 19, 27, 42, 601, DateTimeKind.Utc).AddTicks(2280), "$2b$10$PcqUaiX0rRfvloQjl429puel9qqXjUZi9iSlNH9NeQoRMM51yEz1O", new DateTime(2020, 9, 23, 19, 27, 42, 601, DateTimeKind.Utc).AddTicks(2280) });
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppSettings",
                keyColumn: "AppSettingsId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DocumentsFolder", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 10, 19, 20, 28, 19, 859, DateTimeKind.Utc).AddTicks(5635), "desktop", new DateTime(2020, 10, 19, 20, 28, 19, 859, DateTimeKind.Utc).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsMain", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 10, 19, 20, 28, 19, 895, DateTimeKind.Utc).AddTicks(5301), true, new DateTime(2020, 10, 19, 20, 28, 19, 895, DateTimeKind.Utc).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 10, 19, 20, 28, 19, 895, DateTimeKind.Utc).AddTicks(5301), new DateTime(2020, 10, 19, 20, 28, 19, 895, DateTimeKind.Utc).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 10, 19, 20, 28, 19, 903, DateTimeKind.Utc).AddTicks(5253), new DateTime(2020, 10, 19, 20, 28, 19, 903, DateTimeKind.Utc).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 10, 19, 20, 28, 19, 903, DateTimeKind.Utc).AddTicks(5253), new DateTime(2020, 10, 19, 20, 28, 19, 903, DateTimeKind.Utc).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 10, 19, 20, 28, 20, 4, DateTimeKind.Utc).AddTicks(4860), "$2b$10$/Xh/UimJiQxbbYJrYPML2Of4S2tJNpUrXNFgXTwgW9Du.w4LRtwIm", new DateTime(2020, 10, 19, 20, 28, 20, 4, DateTimeKind.Utc).AddTicks(4860) });
        }
    }
}
