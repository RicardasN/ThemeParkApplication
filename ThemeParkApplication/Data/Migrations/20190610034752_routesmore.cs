using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThemeParkApplication.Data.Migrations
{
    public partial class routesmore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Index",
                table: "RouteAttractions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingHours", "DayOfWeek", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 16, 6, 47, 52, 237, DateTimeKind.Local), "Monday", new DateTime(2019, 7, 16, 6, 47, 52, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingHours", "DayOfWeek", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 16, 6, 47, 52, 237, DateTimeKind.Local), "Monday", new DateTime(2019, 7, 16, 6, 47, 52, 237, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Index",
                table: "RouteAttractions");

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingHours", "DayOfWeek", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 15, 23, 20, 7, 132, DateTimeKind.Local), "Sunday", new DateTime(2019, 7, 15, 23, 20, 7, 132, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingHours", "DayOfWeek", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 15, 23, 20, 7, 132, DateTimeKind.Local), "Sunday", new DateTime(2019, 7, 15, 23, 20, 7, 132, DateTimeKind.Local) });
        }
    }
}
