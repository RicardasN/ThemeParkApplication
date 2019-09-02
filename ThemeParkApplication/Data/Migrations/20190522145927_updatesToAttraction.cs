using Microsoft.EntityFrameworkCore.Migrations;

namespace ThemeParkApplication.Data.Migrations
{
    public partial class updatesToAttraction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsOpen",
                table: "Attractions",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOpen",
                table: "Attractions");
        }
    }
}
