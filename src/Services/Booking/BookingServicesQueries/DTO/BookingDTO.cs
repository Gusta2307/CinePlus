using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServicesQueries.DTO
{
    public class BookingDTO
    {
        public int ID_Cinema { get; set; } //sala

        public int ID_M { get; set; } //id de pelicula

        public string Name_P { get; set; } //nombre de la pelicula

        public string DataHour_P { get; set; } //fecha de la pelicula

        public string Email_User { get; set; }

        public string Selected_Armchairs { get; set; } //butacas reservadas por el usuario

        public string Buy_Cod { get; set; } //codigo de la compra

        public int Total_Tickets { get; set; }

        public int Total_Tickets_Childrens { get; set; }

        public int Total_Tickets_Retired { get; set; }

        public int Total_TicketsStudentsFEU { get; set; }

        public float Total_Money { get; set; } //monto total a pagar

        public int Total_Money_By_Points { get; set; } //monto total a pagar en puntos

        public string DataHour_Booking { get; set; }

        public string IsPaid { get; set; }
    }
}
