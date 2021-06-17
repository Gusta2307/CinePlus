using Microsoft.EntityFrameworkCore.Migrations;

namespace ArmchairDataBase.Migrations
{
    public partial class ArmchairMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Armchairs",
                columns: table => new
                {
                    ID_Cinema = table.Column<int>(type: "INTEGER", nullable: false),
                    Num_Armchair = table.Column<int>(type: "INTEGER", nullable: false),
                    Reserved = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armchairs", x => new { x.ID_Cinema, x.Num_Armchair });
                });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 1, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 37, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 38, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 39, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 40, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 41, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 42, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 43, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 44, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 45, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 46, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 47, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 48, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 49, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 50, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 51, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 52, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 53, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 54, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 55, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 56, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 57, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 58, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 59, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 60, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 61, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 62, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 63, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 36, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 64, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 35, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 33, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 6, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 7, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 8, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 9, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 10, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 11, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 12, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 13, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 14, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 15, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 16, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 17, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 18, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 19, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 20, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 21, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 22, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 23, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 24, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 25, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 26, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 27, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 28, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 29, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 30, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 31, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 32, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 34, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 65, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 66, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 67, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 2, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 3, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 4, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 5, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 6, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 7, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 8, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 9, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 10, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 11, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 12, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 13, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 14, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 15, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 16, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 17, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 18, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 19, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 20, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 21, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 22, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 23, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 24, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 25, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 26, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 27, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 28, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 1, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 98, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 97, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 96, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 68, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 69, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 70, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 71, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 72, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 73, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 74, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 75, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 76, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 77, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 78, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 79, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 80, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 5, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 81, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 83, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 84, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 85, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 86, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 87, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 88, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 89, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 90, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 91, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 92, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 93, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 94, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 95, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 82, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 4, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 3, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 2, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 45, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 46, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 47, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 48, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 49, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 50, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 51, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 52, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 53, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 54, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 55, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 56, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 57, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 58, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 59, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 60, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 61, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 62, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 63, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 64, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 65, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 66, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 67, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 68, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 69, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 70, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 71, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 44, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 43, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 42, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 41, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 13, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 14, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 15, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 16, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 17, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 18, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 19, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 20, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 21, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 22, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 23, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 24, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 25, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 72, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 26, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 28, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 29, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 30, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 31, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 32, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 33, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 34, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 35, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 36, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 37, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 38, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 39, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 40, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 27, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 29, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 73, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 75, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 108, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 109, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 110, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 111, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 112, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 113, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 114, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 115, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 116, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 117, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 118, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 119, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 120, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 121, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 122, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 123, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 124, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 125, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 126, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 127, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 128, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 129, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 130, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 131, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 132, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 133, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 7, 1, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 107, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 106, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 105, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 104, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 76, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 77, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 78, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 79, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 80, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 81, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 82, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 83, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 84, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 85, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 86, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 87, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 88, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 74, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 89, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 91, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 92, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 93, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 94, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 95, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 96, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 97, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 98, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 99, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 100, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 101, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 102, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 103, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 90, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 12, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 30, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 32, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 8, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 9, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 10, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 11, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 12, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 13, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 14, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 15, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 16, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 17, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 18, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 19, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 20, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 21, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 22, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 23, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 24, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 25, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 26, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 27, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 28, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 29, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 30, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 31, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 32, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 33, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 34, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 7, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 35, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 6, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 4, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 60, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 61, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 62, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 63, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 64, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 65, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 66, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 67, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 68, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 69, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 70, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 71, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 72, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 73, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 74, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 75, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 76, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 77, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 78, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 79, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 80, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 81, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 82, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 83, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 1, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 2, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 3, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 5, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 36, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 37, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 38, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 71, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 72, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 73, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 74, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 75, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 76, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 77, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 78, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 79, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 80, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 81, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 82, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 83, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 84, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 85, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 86, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 87, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 88, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 89, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 90, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 91, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 92, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 93, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 94, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 95, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 96, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 97, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 70, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 69, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 68, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 67, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 39, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 40, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 41, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 42, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 43, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 44, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 45, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 46, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 47, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 48, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 49, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 50, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 51, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 59, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 52, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 54, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 55, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 56, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 57, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 58, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 59, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 60, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 61, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 62, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 63, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 64, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 65, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 66, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 53, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 58, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 57, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 56, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 65, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 66, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 67, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 68, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 69, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 70, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 71, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 72, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 73, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 74, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 75, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 76, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 77, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 78, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 79, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 80, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 81, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 82, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 83, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 84, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 85, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 86, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 87, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 88, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 89, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 90, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 91, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 64, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 63, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 62, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 61, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 33, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 34, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 35, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 36, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 37, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 38, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 39, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 40, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 41, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 42, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 43, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 44, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 45, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 92, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 46, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 48, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 49, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 50, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 51, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 52, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 53, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 54, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 55, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 56, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 57, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 58, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 59, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 60, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 47, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 31, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 93, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 95, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 29, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 30, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 31, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 32, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 33, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 34, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 35, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 36, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 37, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 38, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 39, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 40, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 41, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 42, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 43, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 44, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 45, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 46, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 47, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 48, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 49, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 50, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 51, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 52, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 53, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 54, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 55, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 28, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 27, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 26, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 25, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 96, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 97, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 98, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 99, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 1, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 2, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 3, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 4, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 5, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 6, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 7, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 8, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 9, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 8, 94, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 10, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 12, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 13, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 14, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 15, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 16, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 17, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 18, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 19, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 20, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 21, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 22, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 23, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 24, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 9, 11, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 11, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 10, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 9, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 59, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 60, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 61, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 62, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 63, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 64, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 65, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 66, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 67, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 68, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 69, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 70, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 71, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 72, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 73, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 74, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 75, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 76, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 77, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 78, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 79, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 80, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 81, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 82, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 83, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 84, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 85, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 58, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 86, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 57, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 55, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 28, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 29, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 30, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 31, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 32, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 33, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 34, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 35, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 36, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 37, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 38, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 39, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 40, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 41, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 42, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 43, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 44, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 45, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 46, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 47, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 48, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 49, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 50, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 51, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 52, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 53, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 54, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 56, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 87, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 88, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 89, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 14, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 15, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 16, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 17, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 18, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 19, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 20, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 21, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 22, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 23, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 24, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 25, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 26, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 27, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 28, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 29, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 30, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 31, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 32, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 33, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 34, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 35, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 36, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 37, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 38, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 39, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 40, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 13, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 12, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 11, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 10, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 90, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 91, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 92, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 93, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 94, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 95, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 96, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 97, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 98, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 99, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 100, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 101, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 102, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 27, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 103, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 105, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 106, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 107, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 108, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 1, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 2, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 3, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 4, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 5, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 6, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 7, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 8, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 9, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 104, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 26, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 25, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 24, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 34, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 35, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 36, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 37, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 38, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 39, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 40, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 41, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 42, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 43, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 44, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 45, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 46, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 47, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 48, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 49, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 50, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 51, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 52, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 53, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 54, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 55, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 56, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 57, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 58, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 59, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 60, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 33, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 32, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 31, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 30, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 2, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 3, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 4, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 5, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 6, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 7, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 8, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 9, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 10, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 11, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 12, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 13, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 14, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 61, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 15, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 17, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 18, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 19, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 20, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 21, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 22, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 23, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 24, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 25, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 26, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 27, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 28, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 29, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 16, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 41, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 62, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 64, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 97, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 98, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 99, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 100, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 1, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 2, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 3, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 4, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 5, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 6, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 7, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 8, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 9, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 10, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 11, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 12, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 13, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 14, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 15, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 16, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 17, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 18, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 19, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 20, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 21, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 22, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 2, 23, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 96, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 95, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 94, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 93, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 65, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 66, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 67, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 68, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 69, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 70, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 71, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 72, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 73, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 74, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 75, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 76, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 77, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 63, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 78, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 80, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 81, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 82, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 83, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 84, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 85, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 86, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 87, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 88, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 89, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 90, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 91, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 92, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 1, 79, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 42, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 43, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 44, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 47, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 48, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 49, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 50, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 51, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 52, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 53, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 54, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 55, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 56, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 57, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 58, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 59, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 60, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 61, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 62, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 63, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 64, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 65, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 66, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 67, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 68, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 69, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 70, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 71, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 72, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 73, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 46, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 45, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 44, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 43, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 15, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 16, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 17, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 18, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 19, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 20, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 21, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 22, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 23, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 24, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 25, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 26, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 27, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 74, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 28, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 30, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 31, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 32, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 33, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 34, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 35, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 36, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 37, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 38, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 39, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 40, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 41, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 42, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 29, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 14, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 75, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 77, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 110, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 111, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 112, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 113, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 114, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 115, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 116, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 117, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 118, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 119, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 120, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 121, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 122, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 123, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 124, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 125, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 126, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 127, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 128, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 1, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 2, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 3, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 4, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 5, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 6, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 7, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 6, 8, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 109, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 108, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 107, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 106, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 78, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 79, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 80, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 81, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 82, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 83, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 84, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 85, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 86, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 87, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 88, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 89, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 90, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 76, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 91, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 93, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 94, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 95, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 96, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 97, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 98, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 99, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 100, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 101, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 102, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 103, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 104, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 105, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 92, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 98, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 13, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 11, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 77, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 78, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 79, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 80, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 81, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 82, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 83, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 84, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 85, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 86, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 87, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 88, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 89, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 90, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 91, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 92, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 93, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 94, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 95, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 96, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 97, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 98, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 99, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 1, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 2, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 3, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 4, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 76, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 75, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 74, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 73, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 45, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 46, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 47, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 48, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 49, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 50, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 51, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 52, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 53, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 54, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 55, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 56, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 57, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 5, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 58, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 60, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 61, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 62, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 63, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 64, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 65, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 66, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 67, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 68, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 69, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 70, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 71, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 72, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 3, 59, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 12, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 6, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 8, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 41, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 42, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 43, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 44, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 45, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 46, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 47, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 48, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 49, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 50, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 51, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 52, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 53, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 54, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 55, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 56, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 57, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 1, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 2, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 3, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 4, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 5, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 6, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 7, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 8, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 9, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 5, 10, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 40, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 39, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 38, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 37, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 9, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 10, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 11, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 12, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 13, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 14, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 15, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 16, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 17, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 18, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 19, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 20, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 21, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 7, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 22, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 24, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 25, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 26, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 27, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 28, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 29, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 30, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 31, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 32, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 33, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 34, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 35, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 36, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 4, 23, "NO" });

            migrationBuilder.InsertData(
                table: "Armchairs",
                columns: new[] { "ID_Cinema", "Num_Armchair", "Reserved" },
                values: new object[] { 10, 99, "NO" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Armchairs");
        }
    }
}
