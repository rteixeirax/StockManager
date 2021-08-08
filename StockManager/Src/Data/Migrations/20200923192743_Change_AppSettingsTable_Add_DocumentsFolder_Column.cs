using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManager.Src.Data.Migrations
{
    public partial class Change_AppSettingsTable_Add_DocumentsFolder_Column : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentsFolder",
                table: "AppSettings");

            migrationBuilder.UpdateData(
                table: "AppSettings",
                keyColumn: "AppSettingsId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 8, 14, 56, 2, 109, DateTimeKind.Utc).AddTicks(7104), new DateTime(2020, 9, 8, 14, 56, 2, 109, DateTimeKind.Utc).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsMain", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 8, 14, 56, 2, 150, DateTimeKind.Utc).AddTicks(6875), true, new DateTime(2020, 9, 8, 14, 56, 2, 150, DateTimeKind.Utc).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 8, 14, 56, 2, 150, DateTimeKind.Utc).AddTicks(6875), new DateTime(2020, 9, 8, 14, 56, 2, 150, DateTimeKind.Utc).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 8, 14, 56, 2, 159, DateTimeKind.Utc).AddTicks(6821), new DateTime(2020, 9, 8, 14, 56, 2, 159, DateTimeKind.Utc).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 8, 14, 56, 2, 159, DateTimeKind.Utc).AddTicks(6821), new DateTime(2020, 9, 8, 14, 56, 2, 159, DateTimeKind.Utc).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 8, 14, 56, 2, 280, DateTimeKind.Utc).AddTicks(6293), "$2b$10$zCub4BkDY61jj9es4oacDOdE3kROL20mRfUzn62RUSoTwc1/9nXxW", new DateTime(2020, 9, 8, 14, 56, 2, 280, DateTimeKind.Utc).AddTicks(6293) });
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DocumentsFolder",
                table: "AppSettings",
                nullable: true);

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
    }
}
