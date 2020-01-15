using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManager.Database.Migrations
{
    public partial class AddProductLocationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductLocations",
                columns: table => new
                {
                    ProductLocationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Stock = table.Column<float>(nullable: false, defaultValue: 0f),
                    MinStock = table.Column<float>(nullable: false, defaultValue: 0f),
                    ProductId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLocations", x => x.ProductLocationId);
                    table.ForeignKey(
                        name: "FK_ProductLocations_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductLocations_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 15, 21, 51, 21, 391, DateTimeKind.Utc).AddTicks(5728), new DateTime(2020, 1, 15, 21, 51, 21, 391, DateTimeKind.Utc).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 15, 21, 51, 21, 391, DateTimeKind.Utc).AddTicks(5728), new DateTime(2020, 1, 15, 21, 51, 21, 391, DateTimeKind.Utc).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 15, 21, 51, 21, 492, DateTimeKind.Utc).AddTicks(5147), "$2b$10$3C1rUtKBWz8Q3xOQFtPVAe56so25kIJgRLlynP0f5vBZINlwyeBqa", new DateTime(2020, 1, 15, 21, 51, 21, 492, DateTimeKind.Utc).AddTicks(5147) });

            migrationBuilder.CreateIndex(
                name: "IX_ProductLocations_LocationId",
                table: "ProductLocations",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "UniqueProductIdLocationIdPair",
                table: "ProductLocations",
                columns: new[] { "ProductId", "LocationId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductLocations");

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
        }
    }
}
