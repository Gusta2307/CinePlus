using MediatR;
using MovieDataBase;
using MovieDomain;
using MovieServiceEventHandler.Command;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MovieServiceEventHandler
{
    public class MovieCreateEventHandler : INotificationHandler<MovieCreateCommand>
    {
        private readonly ApplicationDbContext _context;

        public MovieCreateEventHandler(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task Handle(MovieCreateCommand notification, CancellationToken cancellationToken)
        {
            await _context.AddAsync(new Movie
            {
                Name_P = notification.Name_P,
                Synopsis = notification.Synopsis,
                Genre = notification.Genre,
                Director = notification.Director,
                Duration = notification.Duration,
                Photo = notification.Photo
            });

            await _context.SaveChangesAsync();
        }
    }
}
