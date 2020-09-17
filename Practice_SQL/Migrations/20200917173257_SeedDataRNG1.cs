using Microsoft.EntityFrameworkCore.Migrations;

namespace Practice_SQL.Migrations
{
    public partial class SeedDataRNG1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: -1);

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "colour", "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Black", "Ford", "Durango", 60081, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "colour", "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Black", "Ford", "Fusion", 72040, "High Country" });

            migrationBuilder.InsertData(
                table: "code_first_car",
                columns: new[] { "id", "colour", "manufacturer", "model", "odometer", "trim_level" },
                values: new object[,]
                {
                    { 49, "Black", "Chevrolet", "Durango", 163715, "R/T" },
                    { 29, "Black", "Chevrolet", "Fusion", 278786, "Awesome" },
                    { 30, "Black", "Ford", "Fusion", 123571, "High Country" },
                    { 31, "Black", "Dodge", "Durango", 3042, "Awesome" },
                    { 32, "Black", "Dodge", "Fusion", 59028, "R/T" },
                    { 33, "Black", "Chevrolet", "Durango", 122879, "R/T" },
                    { 34, "Black", "Ford", "Fusion", 136405, "High Country" },
                    { 35, "Black", "Dodge", "Durango", 245756, "Awesome" },
                    { 36, "Black", "Ford", "Corvette", 255554, "High Country" },
                    { 37, "Black", "Dodge", "Fusion", 110586, "High Country" },
                    { 50, "Black", "Dodge", "Corvette", 246124, "R/T" },
                    { 38, "Black", "Ford", "Durango", 279097, "High Country" },
                    { 40, "Black", "Chevrolet", "Corvette", 82972, "High Country" },
                    { 41, "Black", "Chevrolet", "Corvette", 2740, "R/T" },
                    { 42, "Black", "Chevrolet", "Durango", 99880, "Awesome" },
                    { 43, "Black", "Ford", "Corvette", 161763, "High Country" },
                    { 44, "Black", "Ford", "Corvette", 95119, "Awesome" },
                    { 45, "Black", "Chevrolet", "Corvette", 207669, "R/T" },
                    { 46, "Black", "Ford", "Corvette", 198777, "High Country" },
                    { 47, "Black", "Dodge", "Durango", 23173, "R/T" },
                    { 48, "Black", "Chevrolet", "Fusion", 135522, "High Country" },
                    { 28, "Black", "Dodge", "Fusion", 279522, "High Country" },
                    { 39, "Black", "Ford", "Fusion", 115867, "R/T" },
                    { 27, "Black", "Chevrolet", "Fusion", 260370, "R/T" },
                    { 25, "Black", "Dodge", "Fusion", 18930, "High Country" },
                    { 4, "Black", "Chevrolet", "Durango", 188314, "Awesome" },
                    { 5, "Black", "Chevrolet", "Corvette", 189582, "High Country" },
                    { 6, "Black", "Dodge", "Fusion", 118331, "High Country" },
                    { 7, "Black", "Ford", "Durango", 153647, "R/T" },
                    { 8, "Black", "Dodge", "Corvette", 227813, "High Country" },
                    { 9, "Black", "Chevrolet", "Durango", 267733, "Awesome" },
                    { 10, "Black", "Dodge", "Corvette", 113748, "High Country" },
                    { 11, "Black", "Ford", "Durango", 240751, "R/T" },
                    { 12, "Black", "Dodge", "Fusion", 224845, "Awesome" },
                    { 13, "Black", "Dodge", "Durango", 75008, "R/T" },
                    { 14, "Black", "Ford", "Corvette", 118603, "High Country" },
                    { 15, "Black", "Chevrolet", "Corvette", 123966, "Awesome" },
                    { 16, "Black", "Ford", "Fusion", 176894, "Awesome" },
                    { 17, "Black", "Dodge", "Durango", 178276, "High Country" },
                    { 18, "Black", "Dodge", "Corvette", 265749, "High Country" },
                    { 19, "Black", "Ford", "Fusion", 69924, "R/T" },
                    { 20, "Black", "Dodge", "Corvette", 274278, "Awesome" },
                    { 21, "Black", "Ford", "Fusion", 6983, "Awesome" },
                    { 22, "Black", "Dodge", "Corvette", 248904, "Awesome" },
                    { 23, "Black", "Dodge", "Durango", 96046, "R/T" },
                    { 24, "Black", "Chevrolet", "Fusion", 23396, "R/T" },
                    { 26, "Black", "Ford", "Corvette", 161709, "High Country" },
                    { 1, "Black", "Chevrolet", "Durango", 208070, "R/T" }
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

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "colour", "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Red", "Honda", "Civic", 110000, "LX" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "colour", "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Blue", "Dodge", "Stealth", 98500, "R/T TT" });

            migrationBuilder.InsertData(
                table: "code_first_car",
                columns: new[] { "id", "colour", "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { -1, "Black", "Mitsubishi", "Lancer", 40000, "Evolution" });
        }
    }
}
