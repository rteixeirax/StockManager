using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManager.Database.Source.Migrations
{
    public partial class AddNotificationsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    NotificationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductLocationId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table => {
                    table.PrimaryKey("PK_Notification", x => x.NotificationId);
                    table.ForeignKey(
                        name: "FK_Notification_ProductLocations_ProductLocationId",
                        column: x => x.ProductLocationId,
                        principalTable: "ProductLocations",
                        principalColumn: "ProductLocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppSettings",
                keyColumn: "AppSettingsId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 11, 15, 39, 45, 182, DateTimeKind.Utc).AddTicks(8875), new DateTime(2020, 8, 11, 15, 39, 45, 182, DateTimeKind.Utc).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsMain", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 11, 15, 39, 45, 324, DateTimeKind.Utc).AddTicks(3390), true, new DateTime(2020, 8, 11, 15, 39, 45, 324, DateTimeKind.Utc).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 11, 15, 39, 45, 324, DateTimeKind.Utc).AddTicks(3390), new DateTime(2020, 8, 11, 15, 39, 45, 324, DateTimeKind.Utc).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 11, 15, 39, 45, 208, DateTimeKind.Utc).AddTicks(1546), new DateTime(2020, 8, 11, 15, 39, 45, 208, DateTimeKind.Utc).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 11, 15, 39, 45, 208, DateTimeKind.Utc).AddTicks(1546), new DateTime(2020, 8, 11, 15, 39, 45, 208, DateTimeKind.Utc).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 11, 15, 39, 45, 305, DateTimeKind.Utc).AddTicks(7878), "$2b$10$9S2AI8hOTmBAWHu9OJIuY.zVL.wn55Ql9pm5lZWUQ8rYujxmLnsGO", new DateTime(2020, 8, 11, 15, 39, 45, 305, DateTimeKind.Utc).AddTicks(7878) });

            migrationBuilder.CreateIndex(
                name: "IX_Notification_ProductLocationId",
                table: "Notification",
                column: "ProductLocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notification");

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
        }
    }
}
