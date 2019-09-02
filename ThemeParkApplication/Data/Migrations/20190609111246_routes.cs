using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThemeParkApplication.Data.Migrations
{
    public partial class routes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Tickets",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "RouteID",
                table: "Attractions",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    RouteID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ApplicationUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.RouteID);
                });

            migrationBuilder.CreateTable(
                name: "Cafeteria",
                columns: table => new
                {
                    CafeteriaID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Location = table.Column<string>(nullable: false),
                    Expensiveness = table.Column<string>(nullable: true),
                    AvailableSpaces = table.Column<int>(nullable: false),
                    RouteID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cafeteria", x => x.CafeteriaID);
                    table.ForeignKey(
                        name: "FK_Cafeteria_Routes_RouteID",
                        column: x => x.RouteID,
                        principalTable: "Routes",
                        principalColumn: "RouteID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingHours", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 15, 14, 12, 46, 546, DateTimeKind.Local), new DateTime(2019, 7, 15, 14, 12, 46, 546, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingHours", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 15, 14, 12, 46, 546, DateTimeKind.Local), new DateTime(2019, 7, 15, 14, 12, 46, 546, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_Attractions_RouteID",
                table: "Attractions",
                column: "RouteID");

            migrationBuilder.CreateIndex(
                name: "IX_Cafeteria_RouteID",
                table: "Cafeteria",
                column: "RouteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Attractions_Routes_RouteID",
                table: "Attractions",
                column: "RouteID",
                principalTable: "Routes",
                principalColumn: "RouteID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attractions_Routes_RouteID",
                table: "Attractions");

            migrationBuilder.DropTable(
                name: "Cafeteria");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropIndex(
                name: "IX_Attractions_RouteID",
                table: "Attractions");

            migrationBuilder.DropColumn(
                name: "RouteID",
                table: "Attractions");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Tickets",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingHours", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 15, 12, 22, 27, 930, DateTimeKind.Local), new DateTime(2019, 7, 15, 12, 22, 27, 930, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingHours", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 15, 12, 22, 27, 930, DateTimeKind.Local), new DateTime(2019, 7, 15, 12, 22, 27, 930, DateTimeKind.Local) });
        }
    }
}
