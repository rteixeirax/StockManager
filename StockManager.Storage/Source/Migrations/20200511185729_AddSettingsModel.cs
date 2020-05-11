using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManager.Storage.Source.Migrations {
  public partial class AddSettingsModel : Migration {
    protected override void Up(MigrationBuilder migrationBuilder) {
      migrationBuilder.CreateTable(
          name: "Settings",
          columns: table => new {
            SettingsId = table.Column<int>(nullable: false).Annotation("Sqlite:Autoincrement", true),
            Language = table.Column<string>(nullable: true),
            CreatedAt = table.Column<DateTime>(nullable: true),
            UpdatedAt = table.Column<DateTime>(nullable: true),
          },
          constraints: table => {
            table.PrimaryKey("PK_Settings", x => x.SettingsId);
          });

      migrationBuilder.UpdateData(
          table: "Locations",
          keyColumn: "LocationId",
          keyValue: 1,
          columns: new[] { "CreatedAt", "UpdatedAt" },
          values: new object[] { new DateTime(2020, 5, 11, 18, 57, 28, 93, DateTimeKind.Utc).AddTicks(5433), new DateTime(2020, 5, 11, 18, 57, 28, 93, DateTimeKind.Utc).AddTicks(5433) });

      migrationBuilder.UpdateData(
          table: "Locations",
          keyColumn: "LocationId",
          keyValue: 2,
          columns: new[] { "CreatedAt", "UpdatedAt" },
          values: new object[] { new DateTime(2020, 5, 11, 18, 57, 28, 93, DateTimeKind.Utc).AddTicks(5433), new DateTime(2020, 5, 11, 18, 57, 28, 93, DateTimeKind.Utc).AddTicks(5433) });

      migrationBuilder.UpdateData(
          table: "Roles",
          keyColumn: "RoleId",
          keyValue: 1,
          columns: new[] { "CreatedAt", "UpdatedAt" },
          values: new object[] { new DateTime(2020, 5, 11, 18, 57, 27, 978, DateTimeKind.Utc).AddTicks(8266), new DateTime(2020, 5, 11, 18, 57, 27, 978, DateTimeKind.Utc).AddTicks(8266) });

      migrationBuilder.UpdateData(
          table: "Roles",
          keyColumn: "RoleId",
          keyValue: 2,
          columns: new[] { "CreatedAt", "UpdatedAt" },
          values: new object[] { new DateTime(2020, 5, 11, 18, 57, 27, 978, DateTimeKind.Utc).AddTicks(8266), new DateTime(2020, 5, 11, 18, 57, 27, 978, DateTimeKind.Utc).AddTicks(8266) });

      migrationBuilder.InsertData(
          table: "Settings",
          columns: new[] { "SettingsId", "CreatedAt", "Language", "UpdatedAt" },
          values: new object[] { 1, new DateTime(2020, 5, 11, 18, 57, 27, 952, DateTimeKind.Utc).AddTicks(4484), "pt-PT", new DateTime(2020, 5, 11, 18, 57, 27, 952, DateTimeKind.Utc).AddTicks(4484) });

      migrationBuilder.UpdateData(
          table: "Users",
          keyColumn: "UserId",
          keyValue: 1,
          columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
          values: new object[] { new DateTime(2020, 5, 11, 18, 57, 28, 78, DateTimeKind.Utc).AddTicks(8967), "$2b$10$Hm1bEXmRSjHTQFfoA4bu7uXupkYzVmtVevsxpJjyIYPSq5DlJZUc2", new DateTime(2020, 5, 11, 18, 57, 28, 78, DateTimeKind.Utc).AddTicks(8967) });
    }

    protected override void Down(MigrationBuilder migrationBuilder) {
      migrationBuilder.DropTable(
          name: "Settings");

      migrationBuilder.UpdateData(
          table: "Locations",
          keyColumn: "LocationId",
          keyValue: 1,
          columns: new[] { "CreatedAt", "UpdatedAt" },
          values: new object[] { new DateTime(2020, 3, 3, 20, 32, 32, 520, DateTimeKind.Utc).AddTicks(789), new DateTime(2020, 3, 3, 20, 32, 32, 520, DateTimeKind.Utc).AddTicks(789) });

      migrationBuilder.UpdateData(
          table: "Locations",
          keyColumn: "LocationId",
          keyValue: 2,
          columns: new[] { "CreatedAt", "UpdatedAt" },
          values: new object[] { new DateTime(2020, 3, 3, 20, 32, 32, 520, DateTimeKind.Utc).AddTicks(789), new DateTime(2020, 3, 3, 20, 32, 32, 520, DateTimeKind.Utc).AddTicks(789) });

      migrationBuilder.UpdateData(
          table: "Roles",
          keyColumn: "RoleId",
          keyValue: 1,
          columns: new[] { "CreatedAt", "UpdatedAt" },
          values: new object[] { new DateTime(2020, 3, 3, 20, 32, 32, 401, DateTimeKind.Utc).AddTicks(9296), new DateTime(2020, 3, 3, 20, 32, 32, 402, DateTimeKind.Utc).AddTicks(9238) });

      migrationBuilder.UpdateData(
          table: "Roles",
          keyColumn: "RoleId",
          keyValue: 2,
          columns: new[] { "CreatedAt", "UpdatedAt" },
          values: new object[] { new DateTime(2020, 3, 3, 20, 32, 32, 402, DateTimeKind.Utc).AddTicks(9238), new DateTime(2020, 3, 3, 20, 32, 32, 402, DateTimeKind.Utc).AddTicks(9238) });

      migrationBuilder.UpdateData(
          table: "Users",
          keyColumn: "UserId",
          keyValue: 1,
          columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
          values: new object[] { new DateTime(2020, 3, 3, 20, 32, 32, 505, DateTimeKind.Utc).AddTicks(4339), "$2b$10$ecP/6WJSV3M9QQHeKWjucukTuv5AGTLLIEMOxPCRVqYR65KPVuYA6", new DateTime(2020, 3, 3, 20, 32, 32, 505, DateTimeKind.Utc).AddTicks(4339) });
    }
  }
}
