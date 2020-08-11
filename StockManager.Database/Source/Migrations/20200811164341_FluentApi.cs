using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManager.Database.Source.Migrations
{
    public partial class FluentApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notification_ProductLocations_ProductLocationId",
                table: "Notification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notification",
                table: "Notification");

            migrationBuilder.RenameTable(
                name: "Notification",
                newName: "Notifications");

            migrationBuilder.RenameIndex(
                name: "IX_Notification_ProductLocationId",
                table: "Notifications",
                newName: "IX_Notifications_ProductLocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications",
                column: "NotificationId");

            migrationBuilder.UpdateData(
                table: "AppSettings",
                keyColumn: "AppSettingsId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 11, 16, 43, 40, 350, DateTimeKind.Utc).AddTicks(5905), new DateTime(2020, 8, 11, 16, 43, 40, 350, DateTimeKind.Utc).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsMain", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 11, 16, 43, 40, 393, DateTimeKind.Utc).AddTicks(5500), true, new DateTime(2020, 8, 11, 16, 43, 40, 393, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 11, 16, 43, 40, 393, DateTimeKind.Utc).AddTicks(5500), new DateTime(2020, 8, 11, 16, 43, 40, 393, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 11, 16, 43, 40, 402, DateTimeKind.Utc).AddTicks(3363), new DateTime(2020, 8, 11, 16, 43, 40, 402, DateTimeKind.Utc).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 11, 16, 43, 40, 402, DateTimeKind.Utc).AddTicks(3363), new DateTime(2020, 8, 11, 16, 43, 40, 402, DateTimeKind.Utc).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 11, 16, 43, 40, 505, DateTimeKind.Utc).AddTicks(8277), "$2b$10$57jKadVfOmC/TjR6gKVbmu4ISMjvnBDhAEwIZpDF6ySy84/nNdoO6", new DateTime(2020, 8, 11, 16, 43, 40, 505, DateTimeKind.Utc).AddTicks(8277) });

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_ProductLocations_ProductLocationId",
                table: "Notifications",
                column: "ProductLocationId",
                principalTable: "ProductLocations",
                principalColumn: "ProductLocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_ProductLocations_ProductLocationId",
                table: "Notifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications");

            migrationBuilder.RenameTable(
                name: "Notifications",
                newName: "Notification");

            migrationBuilder.RenameIndex(
                name: "IX_Notifications_ProductLocationId",
                table: "Notification",
                newName: "IX_Notification_ProductLocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notification",
                table: "Notification",
                column: "NotificationId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Notification_ProductLocations_ProductLocationId",
                table: "Notification",
                column: "ProductLocationId",
                principalTable: "ProductLocations",
                principalColumn: "ProductLocationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
