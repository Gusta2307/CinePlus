using MediatR;
using PunctuationDataBase;
using PunctuationDomain;
using PunctuationServiceEventHandler.Command;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PunctuationServiceEventHandler
{
    public class PunctuationMovieCreateEventHandler : INotificationHandler<PunctuationMovieCreateCommand>
    {
        private readonly ApplicationDbContext _context;

        public PunctuationMovieCreateEventHandler(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task Handle(PunctuationMovieCreateCommand notification, CancellationToken cancellationToken)
        {
            await _context.AddAsync(new Punctuation
            {
                ID_M = notification.ID_M,
                Email = notification.Email,
                Points = notification.Points
            });

            await _context.SaveChangesAsync();
        }
    }
}
