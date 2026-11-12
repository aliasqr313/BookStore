using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class AddSampleBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Description", "ImageFileName", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Illia Ponomarenko", "داستان کیف در زمان جنگ", "9780143137894.webp", 15000m, "من به شما نشان خواهم داد که چگونه بود" },
                    { 2, "نویسنده دوم", "توضیح کوتاه کتاب", "9780063317475.webp", 22000m, "کتاب نمونه دوم" },
                    { 3, "نویسنده سوم", "توضیح کوتاه کتاب", "9781620401620.jpg", 18000m, "کتاب نمونه سوم" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
