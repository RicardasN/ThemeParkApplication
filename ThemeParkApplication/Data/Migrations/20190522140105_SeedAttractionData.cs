using Microsoft.EntityFrameworkCore.Migrations;

namespace ThemeParkApplication.Data.Migrations
{
    public partial class SeedAttractionData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Attractions",
                columns: new[] { "AttractionID", "Description", "ImageSrc", "Location", "Name", "Rating" },
                values: new object[] { 1, "This attraction offers amazing experience for a good price!", "https://cdn.pixabay.com/photo/2014/09/17/03/19/roller-coaster-449137_960_720.jpg", "SW", "Kraken", 3.4f });

            migrationBuilder.InsertData(
                table: "Attractions",
                columns: new[] { "AttractionID", "Description", "ImageSrc", "Location", "Name", "Rating" },
                values: new object[] { 2, "This attraction has a well balanced mix of scary twists and speed, are you ready for that?", "https://upload.wikimedia.org/wikipedia/commons/3/39/Adlabs_Imagica_2013_%2810364145606%29.jpg", "NW", "DeathRide", 4.4f });

            migrationBuilder.InsertData(
                table: "Attractions",
                columns: new[] { "AttractionID", "Description", "ImageSrc", "Location", "Name", "Rating" },
                values: new object[] { 3, "This attraction offers amazing experience for a good price!", "https://upload.wikimedia.org/wikipedia/commons/d/d4/Dorney_Park_Steel_Force_Thunderhawk.jpg", "SE", "Loop", 4.9f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "AttractionID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "AttractionID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "AttractionID",
                keyValue: 3);
        }
    }
}
