using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BookingDataBase;
using BookingDomain;
using BookingServiceEventHandler.Command;
using MediatR;

namespace BookingServiceEventHandler
{
    public class BookingUpdateEventHandler : INotificationHandler<BookingUpdateCommand>
    {
        private readonly ApplicationDbContext _context;

        public BookingUpdateEventHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(BookingUpdateCommand notification, CancellationToken cancellationToken)
        {
            var item = _context.Bookings.Find(notification.ID_M, notification.ID_Cinema, notification.DataHour_P, notification.Email_User);
            _context.Bookings.Remove(item);

            await _context.AddAsync(new Booking()
            {
                ID_M = item.ID_M,
                ID_Cinema = item.ID_Cinema,
                DataHour_P = item.DataHour_P,
                Email_User = item.Email_User,
                Selected_Armchairs = item.Selected_Armchairs,
                Buy_Cod = item.Buy_Cod,
                Total_Tickets = item.Total_Tickets,
                Total_Tickets_Childrens = item.Total_Tickets_Childrens,
                Total_Tickets_Retired = item.Total_Tickets_Retired,
                Total_TicketsStudentsFEU = item.Total_TicketsStudentsFEU,
                Total_Money = item.Total_Money,
                Total_Money_By_Points = item.Total_Money_By_Points,
                DataHour_Booking = DateTime.Now.ToString(), //fecha actual
                IsPaid = "SI"
            });

            await _context.SaveChangesAsync();
        }
    }
}
