using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManager.Database.Migrations
{
    public partial class AddStockMovementTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StockMovements",
                columns: table => new
                {
                    StockMovementId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Qty = table.Column<float>(nullable: false),
                    Stock = table.Column<float>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    FromLocationId = table.Column<int>(nullable: false),
                    ToLocationId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockMovements", x => x.StockMovementId);
                    table.ForeignKey(
                        name: "FK_StockMovements_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockMovements_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockMovements_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 15, 21, 14, 59, 907, DateTimeKind.Utc).AddTicks(4789), new DateTime(2020, 1, 15, 21, 14, 59, 907, DateTimeKind.Utc).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 15, 21, 14, 59, 907, DateTimeKind.Utc).AddTicks(4789), new DateTime(2020, 1, 15, 21, 14, 59, 907, DateTimeKind.Utc).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 15, 21, 15, 0, 5, DateTimeKind.Utc).AddTicks(4235), "$2b$10$vL3qzkYxXl6C4Iq4Rqeby.0eoBK8TGZn2KXVyHp3Lo4iJQQre9Cuu", new DateTime(2020, 1, 15, 21, 15, 0, 5, DateTimeKind.Utc).AddTicks(4235) });

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_LocationId",
                table: "StockMovements",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_ProductId",
                table: "StockMovements",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_UserId",
                table: "StockMovements",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockMovements");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 15, 20, 49, 38, 414, DateTimeKind.Utc).AddTicks(8334), new DateTime(2020, 1, 15, 20, 49, 38, 414, DateTimeKind.Utc).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 15, 20, 49, 38, 414, DateTimeKind.Utc).AddTicks(8334), new DateTime(2020, 1, 15, 20, 49, 38, 414, DateTimeKind.Utc).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 15, 20, 49, 38, 512, DateTimeKind.Utc).AddTicks(7695), "$2b$10$igFEt.SfiNWrAwi/t9AtO.xEpWJh7hi2DJ2VBrjxMxf7deHQNPudy", new DateTime(2020, 1, 15, 20, 49, 38, 512, DateTimeKind.Utc).AddTicks(7695) });
        }
    }
}
