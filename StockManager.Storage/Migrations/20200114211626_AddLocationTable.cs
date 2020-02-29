using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManager.Database.Migrations
{
    public partial class AddLocationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 14, 21, 16, 25, 911, DateTimeKind.Utc).AddTicks(764), new DateTime(2020, 1, 14, 21, 16, 25, 911, DateTimeKind.Utc).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 14, 21, 16, 25, 911, DateTimeKind.Utc).AddTicks(764), new DateTime(2020, 1, 14, 21, 16, 25, 911, DateTimeKind.Utc).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 14, 21, 16, 26, 29, DateTimeKind.Utc).AddTicks(67), "$2b$10$8WFi8YXxHcshPC/r7j3yq.WMh46F4QQnk5RemCeZOKmtgfhh4FVwW", new DateTime(2020, 1, 14, 21, 16, 26, 29, DateTimeKind.Utc).AddTicks(67) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 12, 21, 42, 13, 141, DateTimeKind.Utc).AddTicks(230), new DateTime(2020, 1, 12, 21, 42, 13, 141, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 12, 21, 42, 13, 141, DateTimeKind.Utc).AddTicks(230), new DateTime(2020, 1, 12, 21, 42, 13, 141, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 12, 21, 42, 13, 238, DateTimeKind.Utc).AddTicks(9795), "$2b$10$eGGf5hvPB.DFTm5c1CkMS..tESLBS1ny7Jf06Y6UiKaOULQAXGQjK", new DateTime(2020, 1, 12, 21, 42, 13, 238, DateTimeKind.Utc).AddTicks(9795) });
        }
    }
}
