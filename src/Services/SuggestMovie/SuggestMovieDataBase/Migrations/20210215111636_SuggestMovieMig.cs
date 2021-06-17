using Microsoft.EntityFrameworkCore.Migrations;

namespace SuggestMovieDataBase.Migrations
{
    public partial class SuggestMovieMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuggestMovies",
                columns: table => new
                {
                    Type_S = table.Column<string>(type: "TEXT", nullable: false),
                    Selected = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuggestMovies", x => x.Type_S);
                });

            migrationBuilder.InsertData(
                table: "SuggestMovies",
                columns: new[] { "Type_S", "Selected" },
                values: new object[] { "mas vista", 1 });

            migrationBuilder.InsertData(
                table: "SuggestMovies",
                columns: new[] { "Type_S", "Selected" },
                values: new object[] { "mas gustada", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuggestMovies");
        }
    }
}
