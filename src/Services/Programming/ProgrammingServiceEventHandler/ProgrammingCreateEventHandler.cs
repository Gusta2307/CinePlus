using MediatR;
using ProgrammingDataBase;
using ProgrammingDomain.Models;
using ProgrammingServiceEventHandler.Command;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ProgrammingServiceEventHandler
{
    public class ProgrammingCreateEventHandler : INotificationHandler<ProgrammingCreateCommand>
    {
        private readonly ApplicationDbContext _context;
        
        public ProgrammingCreateEventHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(ProgrammingCreateCommand notification, CancellationToken cancellationToken)
        {
            await _context.AddAsync(new Programming
            {
                ID_M = notification.ID_M,
                ID_Cinema = notification.ID_Cinema,
                DataHour_P = notification.DataHour_P,
                Ticket_Price = notification.Ticket_Price,
                Pay_Points = notification.Pay_Points
            });

            await _context.SaveChangesAsync();
        }
    }
}
