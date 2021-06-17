using Microsoft.EntityFrameworkCore.Migrations;

namespace GangawayDataBase.Migrations
{
    public partial class GangwayMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pays",
                columns: table => new
                {
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Credit_Card = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pays", x => x.Email);
                });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "Email", "Credit_Card" },
                values: new object[] { "grettelhernandezmatcom@gmail.com", "9225-9598-0560-9882" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pays");
        }
    }
}
