using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThemeParkApplication.Data.Migrations
{
    public partial class messages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Tickets",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: false),
                    Text = table.Column<string>(nullable: false),
                    SentTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageID);
                });

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingHours", "DayOfWeek", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 14, 13, 33, 29, 218, DateTimeKind.Local), "Saturday", new DateTime(2019, 7, 14, 13, 33, 29, 218, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingHours", "DayOfWeek", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 14, 13, 33, 29, 218, DateTimeKind.Local), "Saturday", new DateTime(2019, 7, 14, 13, 33, 29, 218, DateTimeKind.Local) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_UserId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_UserId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tickets");

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingHours", "DayOfWeek", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 3, 22, 17, 25, 277, DateTimeKind.Local), "Tuesday", new DateTime(2019, 7, 3, 22, 17, 25, 277, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingHours", "DayOfWeek", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 3, 22, 17, 25, 277, DateTimeKind.Local), "Tuesday", new DateTime(2019, 7, 3, 22, 17, 25, 277, DateTimeKind.Local) });
        }
    }
}
