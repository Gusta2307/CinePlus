using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingDataBase.Migrations
{
    public partial class BookingMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    ID_Cinema = table.Column<int>(type: "INTEGER", nullable: false),
                    ID_M = table.Column<int>(type: "INTEGER", nullable: false),
                    DataHour_P = table.Column<string>(type: "TEXT", nullable: false),
                    Email_User = table.Column<string>(type: "TEXT", nullable: false),
                    Selected_Armchairs = table.Column<string>(type: "TEXT", nullable: false),
                    Buy_Cod = table.Column<string>(type: "TEXT", nullable: false),
                    Total_Tickets = table.Column<int>(type: "INTEGER", nullable: false),
                    Total_Tickets_Childrens = table.Column<int>(type: "INTEGER", nullable: false),
                    Total_Tickets_Retired = table.Column<int>(type: "INTEGER", nullable: false),
                    Total_TicketsStudentsFEU = table.Column<int>(type: "INTEGER", nullable: false),
                    Total_Money = table.Column<float>(type: "REAL", nullable: false),
                    Total_Money_By_Points = table.Column<int>(type: "INTEGER", nullable: false),
                    DataHour_Booking = table.Column<string>(type: "TEXT", nullable: false),
                    IsPaid = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => new { x.ID_M, x.ID_Cinema, x.DataHour_P, x.Email_User });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");
        }
    }
}
