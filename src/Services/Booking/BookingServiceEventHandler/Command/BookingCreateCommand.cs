using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServiceEventHandler.Command
{
    public class BookingCreateCommand : INotification
    {
        public int ID_Cinema { get; set; } //sala

        public int ID_M { get; set; } //id de pelicula

        public string DataHour_P { get; set; } //fecha de la pelicula

        public string Email_User { get; set; }

        public string Selected_Armchairs { get; set; } //butacas reservadas por el usuario

        public string Buy_Cod { get; set; } //codigo de la compra

        public int Total_Tickets { get; set; }

        public int Total_Tickets_Childrens { get; set; }

        public int Total_Tickets_Retired { get; set; }

        public int Total_TicketsStudentsFEU { get; set; }

        public int Ticket_Price { get; set; } //precio de la entrada

        public int Pay_Points { get; set; } //precio en puntos

        public bool IsSpectatorDay { get; set; }
    }
}
