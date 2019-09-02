using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThemeParkApplication.Data.Migrations
{
    public partial class Tickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PaymentState = table.Column<bool>(nullable: false),
                    Bank = table.Column<string>(nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketID);
                });

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingHours", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 3, 22, 17, 25, 277, DateTimeKind.Local), new DateTime(2019, 7, 3, 22, 17, 25, 277, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingHours", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 3, 22, 17, 25, 277, DateTimeKind.Local), new DateTime(2019, 7, 3, 22, 17, 25, 277, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingHours", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 3, 20, 49, 48, 913, DateTimeKind.Local), new DateTime(2019, 7, 3, 20, 49, 48, 913, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "WorkingHours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingHours", "StartingHours" },
                values: new object[] { new DateTime(2019, 7, 3, 20, 49, 48, 913, DateTimeKind.Local), new DateTime(2019, 7, 3, 20, 49, 48, 913, DateTimeKind.Local) });
        }
    }
}
