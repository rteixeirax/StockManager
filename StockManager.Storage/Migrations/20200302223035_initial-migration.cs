using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManager.Storage.Migrations
{
    public partial class initialmigration : Migration
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
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    LastLogin = table.Column<DateTime>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Code", "CreatedAt", "UpdatedAt" },
                values: new object[] { 1, "Admin", new DateTime(2020, 3, 2, 22, 30, 34, 443, DateTimeKind.Utc).AddTicks(5466), new DateTime(2020, 3, 2, 22, 30, 34, 443, DateTimeKind.Utc).AddTicks(5466) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Code", "CreatedAt", "UpdatedAt" },
                values: new object[] { 2, "User", new DateTime(2020, 3, 2, 22, 30, 34, 443, DateTimeKind.Utc).AddTicks(5466), new DateTime(2020, 3, 2, 22, 30, 34, 443, DateTimeKind.Utc).AddTicks(5466) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "LastLogin", "Password", "RoleId", "UpdatedAt", "Username" },
                values: new object[] { 1, new DateTime(2020, 3, 2, 22, 30, 34, 557, DateTimeKind.Utc).AddTicks(7963), null, "$2b$10$.ScdPhsJPOmKhzKPnjJu6ePTS38RwwHYmw/4INfm5NVawGWuNiG4G", 1, new DateTime(2020, 3, 2, 22, 30, 34, 557, DateTimeKind.Utc).AddTicks(7963), "Admin" });

            migrationBuilder.CreateIndex(
                name: "UniqueName",
                table: "Locations",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UniqueCode",
                table: "Roles",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "UniqueUsername",
                table: "Users",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
