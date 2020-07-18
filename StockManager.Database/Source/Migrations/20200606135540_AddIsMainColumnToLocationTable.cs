using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManager.Database.Source.Migrations
{
    public partial class AddIsMainColumnToLocationTable : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "Locations");

            migrationBuilder.UpdateData(
                table: "AppSettings",
                keyColumn: "AppSettingsId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 19, 22, 12, 15, DateTimeKind.Utc).AddTicks(1085), new DateTime(2020, 5, 28, 19, 22, 12, 16, DateTimeKind.Utc).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 19, 22, 12, 162, DateTimeKind.Utc).AddTicks(7497), new DateTime(2020, 5, 28, 19, 22, 12, 162, DateTimeKind.Utc).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 19, 22, 12, 162, DateTimeKind.Utc).AddTicks(7497), new DateTime(2020, 5, 28, 19, 22, 12, 162, DateTimeKind.Utc).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 19, 22, 12, 44, DateTimeKind.Utc).AddTicks(2393), new DateTime(2020, 5, 28, 19, 22, 12, 44, DateTimeKind.Utc).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 19, 22, 12, 44, DateTimeKind.Utc).AddTicks(2393), new DateTime(2020, 5, 28, 19, 22, 12, 44, DateTimeKind.Utc).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 19, 22, 12, 147, DateTimeKind.Utc).AddTicks(1280), "$2b$10$FU0sSJy/GT32lnoisqX4BueFInBfAjmjHn1kN7AZI.q7c8xA6iKvq", new DateTime(2020, 5, 28, 19, 22, 12, 147, DateTimeKind.Utc).AddTicks(1280) });
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "Locations",
                nullable: false,
                defaultValue: false);

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
    }
}
