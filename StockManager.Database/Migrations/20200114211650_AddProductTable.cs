using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManager.Database.Migrations
{
    public partial class AddProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Reference = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 14, 21, 16, 50, 302, DateTimeKind.Utc).AddTicks(7033), new DateTime(2020, 1, 14, 21, 16, 50, 302, DateTimeKind.Utc).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 14, 21, 16, 50, 303, DateTimeKind.Utc).AddTicks(7022), new DateTime(2020, 1, 14, 21, 16, 50, 303, DateTimeKind.Utc).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 14, 21, 16, 50, 399, DateTimeKind.Utc).AddTicks(6469), "$2b$10$e19yxQbXCjdErdS96O3obexMTcqNL4hLsLX8HcMj16qJUd8AU5IpW", new DateTime(2020, 1, 14, 21, 16, 50, 399, DateTimeKind.Utc).AddTicks(6469) });

            migrationBuilder.CreateIndex(
                name: "UniqueReference",
                table: "Products",
                column: "Reference",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

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
    }
}
