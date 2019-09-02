using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThemeParkApplication.Data.Migrations
{
    public partial class routeattractions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attractions_Routes_RouteID",
                table: "Attractions");

            migrationBuilder.DropIndex(
                name: "IX_Attractions_RouteID",
                table: "Attractions");

            migrationBuilder.DropColumn(
                name: "RouteID",
                table: "Attractions");

            migrationBuilder.CreateTable(
                name: "RouteAttractions",
                columns: table => new
                {
                    AtractionId = table.Column<int>(nullable: false),
                    AttractionID = table.Column<int>(nullable: true),
                    RouteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouteAttractions", x => new { x.AtractionId, x.RouteId });
                    table.ForeignKey(
                        name: "FK_RouteAttractions_Attractions_AttractionID",
                        column: x => x.AttractionID,
                        principalTable: "Attractions",
                        principalColumn: "AttractionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RouteAttractions_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "RouteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingHours", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 15, 23, 20, 7, 132, DateTimeKind.Local), new DateTime(2019, 7, 15, 23, 20, 7, 132, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingHours", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 15, 23, 20, 7, 132, DateTimeKind.Local), new DateTime(2019, 7, 15, 23, 20, 7, 132, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_RouteAttractions_AttractionID",
                table: "RouteAttractions",
                column: "AttractionID");

            migrationBuilder.CreateIndex(
                name: "IX_RouteAttractions_RouteId",
                table: "RouteAttractions",
                column: "RouteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RouteAttractions");

            migrationBuilder.AddColumn<int>(
                name: "RouteID",
                table: "Attractions",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingHours", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 15, 19, 33, 52, 605, DateTimeKind.Local), new DateTime(2019, 7, 15, 19, 33, 52, 605, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingHours", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 15, 19, 33, 52, 605, DateTimeKind.Local), new DateTime(2019, 7, 15, 19, 33, 52, 605, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_Attractions_RouteID",
                table: "Attractions",
                column: "RouteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Attractions_Routes_RouteID",
                table: "Attractions",
                column: "RouteID",
                principalTable: "Routes",
                principalColumn: "RouteID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
