using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThemeParkApplication.Data.Migrations
{
    public partial class tickets1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_UserId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_UserId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Tickets",
                newName: "Username");

            migrationBuilder.AlterColumn<int>(
                name: "Bank",
                table: "Tickets",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Tickets",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Tickets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingHours", "DayOfWeek", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 15, 12, 22, 27, 930, DateTimeKind.Local), "Sunday", new DateTime(2019, 7, 15, 12, 22, 27, 930, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingHours", "DayOfWeek", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 15, 12, 22, 27, 930, DateTimeKind.Local), "Sunday", new DateTime(2019, 7, 15, 12, 22, 27, 930, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Tickets",
                newName: "UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Bank",
                table: "Tickets",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Tickets",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingHours", "DayOfWeek", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 14, 15, 41, 34, 160, DateTimeKind.Local), "Saturday", new DateTime(2019, 7, 14, 15, 41, 34, 160, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingHours", "DayOfWeek", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 14, 15, 41, 34, 160, DateTimeKind.Local), "Saturday", new DateTime(2019, 7, 14, 15, 41, 34, 160, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UserId",
                table: "Tickets",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_UserId",
                table: "Tickets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
