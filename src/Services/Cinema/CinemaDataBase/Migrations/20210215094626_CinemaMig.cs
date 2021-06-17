using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaDataBase.Migrations
{
    public partial class CinemaMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cinemas",
                columns: table => new
                {
                    ID_Cinema = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Count_Armchair = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas", x => x.ID_Cinema);
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID_Cinema", "Count_Armchair" },
                values: new object[] { 1, 100 });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID_Cinema", "Count_Armchair" },
                values: new object[] { 2, 108 });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID_Cinema", "Count_Armchair" },
                values: new object[] { 3, 99 });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID_Cinema", "Count_Armchair" },
                values: new object[] { 4, 57 });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID_Cinema", "Count_Armchair" },
                values: new object[] { 5, 128 });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID_Cinema", "Count_Armchair" },
                values: new object[] { 6, 133 });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID_Cinema", "Count_Armchair" },
                values: new object[] { 7, 98 });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID_Cinema", "Count_Armchair" },
                values: new object[] { 8, 99 });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID_Cinema", "Count_Armchair" },
                values: new object[] { 9, 83 });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID_Cinema", "Count_Armchair" },
                values: new object[] { 10, 99 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cinemas");
        }
    }
}
