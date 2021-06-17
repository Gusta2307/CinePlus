using MediatR;
using SuggestMovieDataBase;
using SuggestMovieDomain;
using SuggestMovieServiceEventHandler.Command;
using SuggestMovieServicesQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SuggestMovieServiceEventHandler
{
    public class SuggestMovieUpdateEventHandler : INotificationHandler<SuggestMovieUpdateCommand>
    {
        private readonly ApplicationDbContext _context;

        private readonly ISuggestMovieQueryService _progQueryService;

        public SuggestMovieUpdateEventHandler(ApplicationDbContext context, ISuggestMovieQueryService progQueryService)
        {
            _context = context;
            _progQueryService = progQueryService;
        }

        public async Task Handle(SuggestMovieUpdateCommand notification, CancellationToken cancellationToken)
        {
            var collection = _context.SuggestMovies.OrderBy(x => x.Type_S);

            List<SuggestMovie> suggs = new List<SuggestMovie>();

            foreach (var sugg in collection)
            {
                _context.SuggestMovies.Remove(sugg);

                if (sugg.Type_S == notification.Type_S)
                {
                    suggs.Add(new SuggestMovie()
                    {
                        Type_S = sugg.Type_S,
                        Selected = 1
                    });
                }
                else
                {
                    suggs.Add(new SuggestMovie()
                    {
                        Type_S = sugg.Type_S,
                        Selected = 0
                    });
                }
            }

            foreach (var sugg in suggs)
                await _context.AddAsync(sugg);
            
            await _context.SaveChangesAsync();
        }
    }
}
