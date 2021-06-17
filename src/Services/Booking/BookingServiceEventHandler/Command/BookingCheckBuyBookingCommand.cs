using BookingServiceEventHandler.Reponse;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServiceEventHandler.Command
{
    public class BookingCheckBuyBookingCommand : IRequest<BookingResult>
    {
        [Required]
        public string Buy_Cod { get; set; } //codigo de la compra
    }
}
