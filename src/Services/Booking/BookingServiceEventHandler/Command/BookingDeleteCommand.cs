using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace BookingServiceEventHandler.Command
{
    public class BookingDeleteCommand : INotification
    {
        public int ID_Cinema { get; set; } //sala

        public int ID_M { get; set; } //id de pelicula

        public string DataHour_P { get; set; } //fecha de la pelicula

        public string Email_User { get; set; }
    }
}
