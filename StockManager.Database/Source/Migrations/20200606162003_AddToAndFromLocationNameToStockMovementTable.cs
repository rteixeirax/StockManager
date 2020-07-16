using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace StockManager.Database.Source.Migrations
{
    public partial class AddToAndFromLocationNameToStockMovementTable : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FromLocationName",
                table: "StockMovements");

            migrationBuilder.DropColumn(
                name: "ToLocationName",
                table: "StockMovements");

            migrationBuilder.UpdateData(
                table: "AppSettings",
                keyColumn: "AppSettingsId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 13, 55, 39, 673, DateTimeKind.Utc).AddTicks(647), new DateTime(2020, 6, 6, 13, 55, 39, 673, DateTimeKind.Utc).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsMain", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 13, 55, 39, 835, DateTimeKind.Utc).AddTicks(1358), true, new DateTime(2020, 6, 6, 13, 55, 39, 835, DateTimeKind.Utc).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 13, 55, 39, 835, DateTimeKind.Utc).AddTicks(1358), new DateTime(2020, 6, 6, 13, 55, 39, 835, DateTimeKind.Utc).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 13, 55, 39, 698, DateTimeKind.Utc).AddTicks(4493), new DateTime(2020, 6, 6, 13, 55, 39, 698, DateTimeKind.Utc).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 13, 55, 39, 698, DateTimeKind.Utc).AddTicks(4493), new DateTime(2020, 6, 6, 13, 55, 39, 698, DateTimeKind.Utc).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 13, 55, 39, 814, DateTimeKind.Utc).AddTicks(6330), "$2b$10$/srMc8L3u2TpGJhypk8K.Ov3sEduy75Oa/Z.1mw2.o/NKlHfA6p0S", new DateTime(2020, 6, 6, 13, 55, 39, 814, DateTimeKind.Utc).AddTicks(6330) });
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FromLocationName",
                table: "StockMovements",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ToLocationName",
                table: "StockMovements",
                nullable: true);

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
