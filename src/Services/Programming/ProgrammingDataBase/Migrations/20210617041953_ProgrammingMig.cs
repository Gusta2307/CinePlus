using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgrammingDataBase.Migrations
{
    public partial class ProgrammingMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Programming",
                columns: table => new
                {
                    ID_Cinema = table.Column<int>(type: "INTEGER", nullable: false),
                    ID_M = table.Column<int>(type: "INTEGER", nullable: false),
                    DataHour_P = table.Column<string>(type: "TEXT", nullable: false),
                    Ticket_Price = table.Column<float>(type: "REAL", nullable: false),
                    Pay_Points = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programming", x => new { x.ID_M, x.ID_Cinema, x.DataHour_P });
                });

            migrationBuilder.InsertData(
                table: "Programming",
                columns: new[] { "DataHour_P", "ID_Cinema", "ID_M", "Pay_Points", "Ticket_Price" },
                values: new object[] { "14-06-2021 12:40", 3, 1, 8, 15f });

            migrationBuilder.InsertData(
                table: "Programming",
                columns: new[] { "DataHour_P", "ID_Cinema", "ID_M", "Pay_Points", "Ticket_Price" },
                values: new object[] { "14-06-2021 10:30", 1, 8, 5, 10f });

            migrationBuilder.InsertData(
                table: "Programming",
                columns: new[] { "DataHour_P", "ID_Cinema", "ID_M", "Pay_Points", "Ticket_Price" },
                values: new object[] { "14-06-2021 10:30", 3, 2, 5, 10f });

            migrationBuilder.InsertData(
                table: "Programming",
                columns: new[] { "DataHour_P", "ID_Cinema", "ID_M", "Pay_Points", "Ticket_Price" },
                values: new object[] { "14-06-2021 08:30", 3, 4, 2, 7.2f });

            migrationBuilder.InsertData(
                table: "Programming",
                columns: new[] { "DataHour_P", "ID_Cinema", "ID_M", "Pay_Points", "Ticket_Price" },
                values: new object[] { "15-06-2021 20:00", 9, 5, 11, 21f });

            migrationBuilder.InsertData(
                table: "Programming",
                columns: new[] { "DataHour_P", "ID_Cinema", "ID_M", "Pay_Points", "Ticket_Price" },
                values: new object[] { "16-06-2021 09:40", 5, 10, 4, 8.4f });

            migrationBuilder.InsertData(
                table: "Programming",
                columns: new[] { "DataHour_P", "ID_Cinema", "ID_M", "Pay_Points", "Ticket_Price" },
                values: new object[] { "16-06-2021 09:40", 7, 10, 6, 12f });

            migrationBuilder.InsertData(
                table: "Programming",
                columns: new[] { "DataHour_P", "ID_Cinema", "ID_M", "Pay_Points", "Ticket_Price" },
                values: new object[] { "17-06-2021 2:20", 5, 8, 4, 12.5f });

            migrationBuilder.InsertData(
                table: "Programming",
                columns: new[] { "DataHour_P", "ID_Cinema", "ID_M", "Pay_Points", "Ticket_Price" },
                values: new object[] { "17-06-2021 2:20", 6, 3, 13, 25f });

            migrationBuilder.InsertData(
                table: "Programming",
                columns: new[] { "DataHour_P", "ID_Cinema", "ID_M", "Pay_Points", "Ticket_Price" },
                values: new object[] { "19-06-2021 11:30", 7, 7, 5, 10f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Programming");
        }
    }
}
