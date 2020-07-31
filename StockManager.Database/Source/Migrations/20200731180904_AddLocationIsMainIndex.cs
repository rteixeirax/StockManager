using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManager.Database.Source.Migrations
{
    public partial class AddLocationIsMainIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppSettings",
                keyColumn: "AppSettingsId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 7, 31, 18, 9, 3, 946, DateTimeKind.Utc).AddTicks(9999), new DateTime(2020, 7, 31, 18, 9, 3, 946, DateTimeKind.Utc).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsMain", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 7, 31, 18, 9, 4, 95, DateTimeKind.Utc).AddTicks(3976), true, new DateTime(2020, 7, 31, 18, 9, 4, 95, DateTimeKind.Utc).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 7, 31, 18, 9, 4, 95, DateTimeKind.Utc).AddTicks(3976), new DateTime(2020, 7, 31, 18, 9, 4, 95, DateTimeKind.Utc).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 7, 31, 18, 9, 3, 971, DateTimeKind.Utc).AddTicks(3903), new DateTime(2020, 7, 31, 18, 9, 3, 971, DateTimeKind.Utc).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 7, 31, 18, 9, 3, 971, DateTimeKind.Utc).AddTicks(3903), new DateTime(2020, 7, 31, 18, 9, 3, 971, DateTimeKind.Utc).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 7, 31, 18, 9, 4, 74, DateTimeKind.Utc).AddTicks(8943), "$2b$10$lXKtF0e7xLF9FYUKFYR4kuuPC94AXl63VUvDPBEJMaUFIa3v9wGlq", new DateTime(2020, 7, 31, 18, 9, 4, 74, DateTimeKind.Utc).AddTicks(8943) });

            migrationBuilder.CreateIndex(
                name: "IsMainIndex",
                table: "Locations",
                column: "IsMain");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IsMainIndex",
                table: "Locations");

            migrationBuilder.UpdateData(
                table: "AppSettings",
                keyColumn: "AppSettingsId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 16, 20, 2, 276, DateTimeKind.Utc).AddTicks(6142), new DateTime(2020, 6, 6, 16, 20, 2, 276, DateTimeKind.Utc).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsMain", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 16, 20, 2, 426, DateTimeKind.Utc).AddTicks(9872), true, new DateTime(2020, 6, 6, 16, 20, 2, 426, DateTimeKind.Utc).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 16, 20, 2, 426, DateTimeKind.Utc).AddTicks(9872), new DateTime(2020, 6, 6, 16, 20, 2, 426, DateTimeKind.Utc).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 16, 20, 2, 303, DateTimeKind.Utc).AddTicks(9519), new DateTime(2020, 6, 6, 16, 20, 2, 303, DateTimeKind.Utc).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 16, 20, 2, 303, DateTimeKind.Utc).AddTicks(9519), new DateTime(2020, 6, 6, 16, 20, 2, 303, DateTimeKind.Utc).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 16, 20, 2, 406, DateTimeKind.Utc).AddTicks(4670), "$2b$10$rn5xwUrgAdCHiFcQEHrtOeExRVWU/l.wCWcaATKn.6tnPjbpg4bZa", new DateTime(2020, 6, 6, 16, 20, 2, 406, DateTimeKind.Utc).AddTicks(4670) });
        }
    }
}
