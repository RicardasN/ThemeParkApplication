using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThemeParkApplication.Data.Migrations
{
    public partial class routesAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TempAtractionID",
                table: "Routes",
                nullable: false,
                defaultValue: 0);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TempAtractionID",
                table: "Routes");

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
        }
    }
}
