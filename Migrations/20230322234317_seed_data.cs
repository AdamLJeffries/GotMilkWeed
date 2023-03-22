using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GotMilkWeed.Migrations
{
    /// <inheritdoc />
    public partial class seed_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from milkweedVarieties");
            
            migrationBuilder.InsertData(
                table: "milkweedVarieties",
                columns: new[] { "Id", "IsToxicToMonarchs", "Name", "Region" },
                values: new object[,]
                {
                    { 1, true, "Common Milkweed", "North America" },
                    { 2, false, "Butterfly Weed", "North America" },
                    { 3, false, "Swamp Milkweed", "North America" },
                    { 4, true, "Showy Butterfly", "North America" },
                    { 5, true, "Whorled Milkweed", "North America" },
                    { 6, false, "Green Milkweed", "North America" },
                    { 7, true, "Antelope Horns", "North America" },
                    { 8, true, "Purple Milkweed", "North America" },
                    { 9, false, "Sand Milkweed", "North American" },
                    { 10, true, "Red Milkweed", "North America" },
                    { 11, true, "Poke Milkweed", "North America" },
                    { 12, false, "Texas Milkweed", "North America" },
                    { 13, true, "Sullivants Milkweed", "North America" },
                    { 14, true, "Horsetail Milkweed", "North America" },
                    { 15, true, "Clasping Milkweed", "North America" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "milkweedVarieties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "milkweedVarieties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "milkweedVarieties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "milkweedVarieties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "milkweedVarieties",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "milkweedVarieties",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "milkweedVarieties",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "milkweedVarieties",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "milkweedVarieties",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "milkweedVarieties",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "milkweedVarieties",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "milkweedVarieties",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "milkweedVarieties",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "milkweedVarieties",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "milkweedVarieties",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
