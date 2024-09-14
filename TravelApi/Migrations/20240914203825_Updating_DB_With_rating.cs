using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class Updating_DB_With_rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OverallRating",
                table: "Destinations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 1,
                column: "OverallRating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 2,
                column: "OverallRating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 3,
                column: "OverallRating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 4,
                column: "OverallRating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 5,
                column: "OverallRating",
                value: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OverallRating",
                table: "Destinations",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 1,
                column: "OverallRating",
                value: "5 stars");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 2,
                column: "OverallRating",
                value: "3 stars");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 3,
                column: "OverallRating",
                value: "4 stars");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 4,
                column: "OverallRating",
                value: "5 stars");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 5,
                column: "OverallRating",
                value: "5 stars");
        }
    }
}
