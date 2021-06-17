using MediatR;
using ProgrammingDataBase;
using ProgrammingDomain.Models;
using ProgrammingServiceEventHandler.Command;
using ProgrammingServicesQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgrammingServiceEventHandler
{
    public class ProgrammingUpdateMovieEventHandler : INotificationHandler<ProgrammingUpdateMovieCommand>
    {
        private readonly ApplicationDbContext _context;

        private readonly IProgrammingQueryService _progQueryService;

        public ProgrammingUpdateMovieEventHandler(ApplicationDbContext context, IProgrammingQueryService progQueryService)
        {
            _context = context;
            _progQueryService = progQueryService;
        }

        public async Task Handle(ProgrammingUpdateMovieCommand notification, CancellationToken cancellationToken)
        {
            var item = _context.Programming.Find(notification.ID_M, notification.ID_Cinema, notification.DataHour_P);
            _context.Programming.Remove(item);

            await _context.AddAsync(new Programming()
            {
                ID_M = notification.New_ID_Movie,
                ID_Cinema = item.ID_Cinema,
                DataHour_P = item.DataHour_P,
                Ticket_Price = item.Ticket_Price,
                Pay_Points = item.Pay_Points
            });

            await _context.SaveChangesAsync();
        }
    }
}
