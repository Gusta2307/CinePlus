using Microsoft.EntityFrameworkCore.Migrations;

namespace PrintDataBase.Migrations
{
    public partial class PrintMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Printers",
                columns: table => new
                {
                    ID_Printer = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PrinterName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Printers", x => x.ID_Printer);
                });

            migrationBuilder.InsertData(
                table: "Printers",
                columns: new[] { "ID_Printer", "PrinterName" },
                values: new object[] { 1, "Adobe PDF" });

            migrationBuilder.InsertData(
                table: "Printers",
                columns: new[] { "ID_Printer", "PrinterName" },
                values: new object[] { 2, "Fax" });

            migrationBuilder.InsertData(
                table: "Printers",
                columns: new[] { "ID_Printer", "PrinterName" },
                values: new object[] { 3, "Microsoft XPS Document Writer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Printers");
        }
    }
}
