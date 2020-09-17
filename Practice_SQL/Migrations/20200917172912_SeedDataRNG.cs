using Microsoft.EntityFrameworkCore.Migrations;

namespace Practice_SQL.Migrations
{
    public partial class SeedDataRNG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "code_first_car",
                columns: new[] { "id", "colour", "manufacturer", "model", "odometer", "trim_level" },
                values: new object[,]
                {
                    { 1, "Black", "Chevrolet", "Fusion", 0, "Awesome" },
                    { 28, "Black", "Dodge", "Corvette", 1277, "Awesome" },
                    { 29, "Black", "Ford", "Durango", 277687, "R/T" },
                    { 30, "Black", "Ford", "Fusion", 254224, "Awesome" },
                    { 31, "Black", "Dodge", "Corvette", 71577, "R/T" },
                    { 32, "Black", "Dodge", "Fusion", 191825, "High Country" },
                    { 33, "Black", "Ford", "Fusion", 80711, "R/T" },
                    { 34, "Black", "Dodge", "Fusion", 242729, "R/T" },
                    { 35, "Black", "Ford", "Durango", 61323, "R/T" },
                    { 36, "Black", "Chevrolet", "Corvette", 85819, "Awesome" },
                    { 37, "Black", "Dodge", "Durango", 76140, "R/T" },
                    { 38, "Black", "Chevrolet", "Fusion", 79770, "Awesome" },
                    { 39, "Black", "Chevrolet", "Corvette", 203786, "High Country" },
                    { 40, "Black", "Ford", "Fusion", 53775, "R/T" },
                    { 41, "Black", "Ford", "Durango", 161510, "R/T" },
                    { 42, "Black", "Dodge", "Durango", 298194, "R/T" },
                    { 43, "Black", "Chevrolet", "Fusion", 34187, "High Country" },
                    { 44, "Black", "Dodge", "Durango", 69880, "R/T" },
                    { 45, "Black", "Chevrolet", "Corvette", 17577, "R/T" },
                    { 46, "Black", "Dodge", "Fusion", 241688, "R/T" },
                    { 47, "Black", "Chevrolet", "Corvette", 101030, "High Country" },
                    { 48, "Black", "Ford", "Fusion", 262649, "Awesome" },
                    { 27, "Black", "Chevrolet", "Fusion", 19257, "High Country" },
                    { 26, "Black", "Ford", "Durango", 294750, "High Country" },
                    { 25, "Black", "Chevrolet", "Corvette", 118234, "Awesome" },
                    { 24, "Black", "Ford", "Fusion", 190756, "Awesome" },
                    { 2, "Black", "Chevrolet", "Fusion", 27320, "High Country" },
                    { 3, "Black", "Ford", "Durango", 48696, "R/T" },
                    { 4, "Black", "Ford", "Fusion", 262923, "Awesome" },
                    { 5, "Black", "Ford", "Corvette", 189920, "High Country" },
                    { 6, "Black", "Chevrolet", "Corvette", 30512, "R/T" },
                    { 7, "Black", "Ford", "Durango", 216400, "Awesome" },
                    { 8, "Black", "Dodge", "Fusion", 234644, "High Country" },
                    { 9, "Black", "Dodge", "Fusion", 258688, "High Country" },
                    { 10, "Black", "Ford", "Fusion", 243988, "R/T" },
                    { 11, "Black", "Chevrolet", "Durango", 83714, "Awesome" },
                    { 49, "Black", "Chevrolet", "Corvette", 221038, "R/T" },
                    { 12, "Black", "Ford", "Durango", 220189, "High Country" },
                    { 14, "Black", "Dodge", "Corvette", 289448, "R/T" },
                    { 15, "Black", "Dodge", "Fusion", 251240, "Awesome" },
                    { 16, "Black", "Chevrolet", "Durango", 280350, "R/T" },
                    { 17, "Black", "Dodge", "Durango", 255740, "R/T" },
                    { 18, "Black", "Dodge", "Corvette", 287963, "Awesome" },
                    { 19, "Black", "Dodge", "Durango", 168189, "R/T" },
                    { 20, "Black", "Chevrolet", "Durango", 87086, "High Country" },
                    { 21, "Black", "Chevrolet", "Corvette", 169562, "R/T" },
                    { 22, "Black", "Chevrolet", "Durango", 135354, "High Country" },
                    { 23, "Black", "Chevrolet", "Corvette", 24200, "R/T" },
                    { 13, "Black", "Chevrolet", "Corvette", 192930, "Awesome" },
                    { 50, "Black", "Ford", "Durango", 60121, "R/T" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 50);
        }
    }
}