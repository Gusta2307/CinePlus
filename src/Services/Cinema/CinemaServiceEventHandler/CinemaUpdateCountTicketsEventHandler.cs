using CinemaDataBase;
using CinemaDomain;
using CinemaServiceEventHandler.Command;
using CinemaServicesQuery;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CinemaServiceEventHandler
{
    public class CinemaUpdateCountTicketsEventHandler : INotificationHandler<CinemaUpdateCountTicketsCommand>
    {
        private readonly ApplicationDbContext _context;

        private readonly ICinemaQueryService _cinemaQueryService;

        public CinemaUpdateCountTicketsEventHandler(ApplicationDbContext context, ICinemaQueryService cinemaQueryService)
        {
            _context = context;
            _cinemaQueryService = cinemaQueryService;
        }

        public async Task Handle(CinemaUpdateCountTicketsCommand notification, CancellationToken cancellationToken)
        {
            int new_count_tickets;
            var item = _context.Cinemas.Find(notification.ID_Cinema);

            if (notification.Operation == Command.Action.Sum)
                new_count_tickets = item.Count_Armchair + notification.Update_Count_Armchair;
            else new_count_tickets = item.Count_Armchair - notification.Update_Count_Armchair;

            _context.Cinemas.Remove(item);

            await _context.AddAsync(new Cinema()
            {
                ID_Cinema = notification.ID_Cinema,
                Count_Armchair = new_count_tickets
            });

            await _context.SaveChangesAsync();
        }
    }
}
