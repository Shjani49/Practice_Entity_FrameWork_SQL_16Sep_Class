using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Practice_SQL.Migrations
{
    public partial class ForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "manufacturer",
                table: "code_first_car");

            migrationBuilder.AddColumn<int>(
                name: "manufacturer_id",
                table: "code_first_car",
                type: "int(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "manufacturer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(10)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci"),
                    year_founded = table.Column<int>(type: "int(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manufacturer", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "manufacturer",
                columns: new[] { "id", "name", "year_founded" },
                values: new object[,]
                {
                    { 1, "Chevrolet", 1911 },
                    { 2, "Ford", 1903 },
                    { 3, "Tesla", null },
                    { 4, "Dodge", null },
                    { 5, "Toyota", 1937 },
                    { 6, "Honda", 1946 },
                    { 7, "Mitsubishi", null },
                    { 8, "Nissan", null }
                });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 236538, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 294356, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Corvette", 154746 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 187814, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 200710, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 49376, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Fusion", 13739 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Durango", 134788 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Corvette", 19503 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Fusion", 221560 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 222762, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 214960, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 222791 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 38943, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 60264, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 74346 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 1394, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 134184, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Durango", 23136 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 115904, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 280638, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 117764, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 163918, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 124556 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 199479, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 6075, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Corvette", 248707 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 212064, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 37897 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 253386, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 119447, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 102908, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 169264, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 211719, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 43215, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 24454, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 230320, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Corvette", 182085 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 287470, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 164120 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 136620 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 120921, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 174285 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 202990 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Durango", 228620 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 54504 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 58346, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 44481, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Corvette", 274594 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 25762, "Awesome" });

            migrationBuilder.CreateIndex(
                name: "FK_CodeFirstCar_Manufacturer",
                table: "code_first_car",
                column: "manufacturer_id");

            migrationBuilder.AddForeignKey(
                name: "FK_CodeFirstCar_Manufacturer",
                table: "code_first_car",
                column: "manufacturer_id",
                principalTable: "manufacturer",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CodeFirstCar_Manufacturer",
                table: "code_first_car");

            migrationBuilder.DropTable(
                name: "manufacturer");

            migrationBuilder.DropIndex(
                name: "FK_CodeFirstCar_Manufacturer",
                table: "code_first_car");

            migrationBuilder.DropColumn(
                name: "manufacturer_id",
                table: "code_first_car");

            migrationBuilder.AddColumn<string>(
                name: "manufacturer",
                table: "code_first_car",
                type: "varchar(30)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_general_ci");

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Durango", 208070, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 60081, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Ford", "Fusion", 72040 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", 188314, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Corvette", 189582, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 118331, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Ford", "Durango", 153647 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Dodge", "Corvette", 227813 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Durango", 267733 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Dodge", "Corvette", 113748 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Durango", 240751, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Fusion", 224845, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Dodge", 75008 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 118603, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Corvette", 123966, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Ford", 176894 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Durango", 178276, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 265749, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Ford", "Fusion", 69924 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Corvette", 274278, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 6983, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Corvette", 248904, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Durango", 96046, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Chevrolet", 23396 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Fusion", 18930, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Corvette", 161709, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Fusion", 260370 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 279522, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Chevrolet", 278786 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Fusion", 123571, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 3042, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Fusion", 59028, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Durango", 122879, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 136405, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Durango", 245756, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Corvette", 255554, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 110586, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Ford", "Durango", 279097 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Fusion", 115867, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Chevrolet", 82972 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Chevrolet", 2740 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Durango", 99880, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Ford", 161763 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Ford", 95119 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Corvette", 207669 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Ford", 198777 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 23173, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Fusion", 135522, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Durango", 163715 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Corvette", 246124, "R/T" });
        }
    }
}
