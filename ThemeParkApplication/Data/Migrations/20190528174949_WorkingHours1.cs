using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThemeParkApplication.Data.Migrations
{
    public partial class WorkingHours1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WorkingHours",
                columns: new[] { "Id", "ClosingHours", "DayOfWeek", "StartingHours" },
                values: new object[] { 2, new DateTime(2019, 7, 3, 20, 49, 48, 913, DateTimeKind.Local), "Tuesday", new DateTime(2019, 7, 3, 20, 49, 48, 913, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "WorkingHours",
                columns: new[] { "Id", "ClosingHours", "DayOfWeek", "StartingHours" },
                values: new object[] { 3, new DateTime(2019, 7, 3, 20, 49, 48, 913, DateTimeKind.Local), "Tuesday", new DateTime(2019, 7, 3, 20, 49, 48, 913, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
