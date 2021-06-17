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
    public class BookingDeleteEventHadler : INotificationHandler<BookingDeleteCommand>
    {
        private readonly ApplicationDbContext _context;

        public BookingDeleteEventHadler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(BookingDeleteCommand notification, CancellationToken cancellationToken)
        {
            var entity = new Booking()
            {
                ID_M = notification.ID_M,
                ID_Cinema = notification.ID_Cinema,
                DataHour_P = notification.DataHour_P,
                Email_User = notification.Email_User
            };
            _context.Bookings.Attach(entity);
            _context.Bookings.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
