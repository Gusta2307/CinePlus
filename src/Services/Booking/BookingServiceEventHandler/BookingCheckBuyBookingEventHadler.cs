using BookingDataBase;
using BookingDomain;
using BookingServiceEventHandler.Command;
using BookingServiceEventHandler.Reponse;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ServiceCommonMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookingServiceEventHandler
{
    public class BookingCheckBuyBookingEventHadler : IRequestHandler<BookingCheckBuyBookingCommand, BookingResult>
    {
        private readonly ApplicationDbContext _context;

        public BookingCheckBuyBookingEventHadler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<BookingResult> Handle(BookingCheckBuyBookingCommand request, CancellationToken cancellationToken)
        {
            Booking buy = null;
            try
            {
                buy = (await _context.Bookings.SingleAsync(x => x.Buy_Cod == request.Buy_Cod));
            }
            catch(Exception e)
            {
                return new BookingResult
                {
                    Message = "La reserva no se existe"
                };
            }

            DateTime date_booking = DateTime.Parse(buy.DataHour_Booking);
            BookingResult result = new BookingResult();

            if(date_booking.Date == DateTime.Now.Date)
            {
                double min = Math.Abs(date_booking.Subtract(DateTime.Now).TotalMinutes);

                if (min <= 10)
                {
                    if (buy.IsPaid == "SI")
                    {
                        return new BookingResult
                        {
                            Message = "La reserva ya fue pagada"
                        };
                    }
                    else return new BookingResult
                    {
                        Message = "Pay",
                        ID_Cinema = buy.ID_Cinema,
                        ID_M = buy.ID_M,
                        DataHour_P = buy.DataHour_P,
                        Email_User = buy.Email_User
                    };
                }
                else return new BookingResult
                {
                    Message = "La reserva ha caducado"
                };
            }

            return new BookingResult
            {
                Message = "La reserva ha caduco"
            };
        }
    }
}
