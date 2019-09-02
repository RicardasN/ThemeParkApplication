using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThemeParkApplication.Data.Migrations
{
    public partial class messagesUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Messages",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingHours", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 14, 15, 41, 34, 160, DateTimeKind.Local), new DateTime(2019, 7, 14, 15, 41, 34, 160, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingHours", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 14, 15, 41, 34, 160, DateTimeKind.Local), new DateTime(2019, 7, 14, 15, 41, 34, 160, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Messages",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingHours", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 14, 13, 33, 29, 218, DateTimeKind.Local), new DateTime(2019, 7, 14, 13, 33, 29, 218, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingHours", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 14, 13, 33, 29, 218, DateTimeKind.Local), new DateTime(2019, 7, 14, 13, 33, 29, 218, DateTimeKind.Local) });
        }
    }
}
