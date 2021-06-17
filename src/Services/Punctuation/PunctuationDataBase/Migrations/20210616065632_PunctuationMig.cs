using Microsoft.EntityFrameworkCore.Migrations;

namespace PunctuationDataBase.Migrations
{
    public partial class PunctuationMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PunctuationsMovies",
                columns: table => new
                {
                    ID_M = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Points = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PunctuationsMovies", x => new { x.ID_M, x.Email });
                });

            migrationBuilder.InsertData(
                table: "PunctuationsMovies",
                columns: new[] { "Email", "ID_M", "Points" },
                values: new object[] { "grettelhernandezmatcom@gmail.com", 7, 5 });

            migrationBuilder.InsertData(
                table: "PunctuationsMovies",
                columns: new[] { "Email", "ID_M", "Points" },
                values: new object[] { "melissa.sanchez@gmail.com", 2, 4 });

            migrationBuilder.InsertData(
                table: "PunctuationsMovies",
                columns: new[] { "Email", "ID_M", "Points" },
                values: new object[] { "grettelhernandezmatcom@gmail.com", 2, 5 });

            migrationBuilder.InsertData(
                table: "PunctuationsMovies",
                columns: new[] { "Email", "ID_M", "Points" },
                values: new object[] { "melissa.sanchez@gmail.com", 3, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PunctuationsMovies");
        }
    }
}
