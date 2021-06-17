using MediatR;
using MovieDataBase;
using MovieDomain;
using MovieServiceEventHandler.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MovieServiceEventHandler
{
    public class MovieDeleteEventHandler : INotificationHandler<MovieDeleteCommand>
    {
        private readonly ApplicationDbContext _context;

        public MovieDeleteEventHandler(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task Handle(MovieDeleteCommand notification, CancellationToken cancellationToken)
        {
            var entity = new Movie()
            {
                ID_M = notification.ID_M
            };
            _context.Movies.Attach(entity);
            _context.Movies.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
