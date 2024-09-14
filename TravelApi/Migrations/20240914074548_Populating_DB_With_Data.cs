using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class Populating_DB_With_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Review",
                keyValue: null,
                column: "Review",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Review",
                table: "Destinations",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "OverallRating",
                keyValue: null,
                column: "OverallRating",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "OverallRating",
                table: "Destinations",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "City", "Country", "DestinationName", "OverallRating", "Review", "UserName" },
                values: new object[,]
                {
                    { 1, "Lagos", "Nigeria", "Silicon Valley", "5 stars", "The place is a great place for startups to thrive in", "Dynasty" },
                    { 2, "Acrra", "Ghana", "Boston", "3 stars", "Boston is a very very cold city in the United States of America", "Daniel" },
                    { 3, "Brocklyn", "USA", "Michighan", "4 stars", "A Nice place to be in with a loved one... Its a peaceful place to be in", "Mike" },
                    { 4, "Southampton", "United Kingdom", "Manchester", "5 stars", "Great Weather in Manchester, and its the home to my beloved club Manchester United", "Taylor" },
                    { 5, "Alberta", "Canada", "Toronto", "5 stars", "Ontario has got to be one of the best States in the country Canada, not only is Toronto the capital of the Country but it is also a great place to travel to", "Dynasty" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Review",
                table: "Destinations",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "OverallRating",
                table: "Destinations",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
