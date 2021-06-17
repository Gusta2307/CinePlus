using Microsoft.EntityFrameworkCore.Migrations;

namespace EstadisticDataBase.Migrations
{
    public partial class EstadisticMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estadistics",
                columns: table => new
                {
                    ID_E = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name_E = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadistics", x => x.ID_E);
                });

            migrationBuilder.InsertData(
                table: "Estadistics",
                columns: new[] { "ID_E", "Name_E" },
                values: new object[] { 1, "Anual" });

            migrationBuilder.InsertData(
                table: "Estadistics",
                columns: new[] { "ID_E", "Name_E" },
                values: new object[] { 2, "Mensual" });

            migrationBuilder.InsertData(
                table: "Estadistics",
                columns: new[] { "ID_E", "Name_E" },
                values: new object[] { 3, "Diaria" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estadistics");
        }
    }
}
