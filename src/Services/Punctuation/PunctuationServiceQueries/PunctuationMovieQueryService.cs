using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PunctuationDataBase;
using PunctuationProxies.Movie;
using PunctuationServiceQueries.DTO;
using ServiceCommonCollection;
using ServiceCommonMapping;
using ServiceCommonPapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PunctuationServiceQueries
{
    public interface IPunctuationMovieQueryService
    {
        Task<DataCollection<PunctuationDTO>> GetAllAsync();

        Task<PunctuationDTO> GetAsync(int id_m, string email_user);

        List<string> GetMoreLikeAsync();
    }

    public class PunctuationMovieQueryService : IPunctuationMovieQueryService
    {
        private readonly ApplicationDbContext _context;

        private readonly IMovieProxy _movieProxy;


        private readonly ILogger<PunctuationMovieQueryService> _logger;

        public PunctuationMovieQueryService(ApplicationDbContext context, ILogger<PunctuationMovieQueryService> logger, IMovieProxy movieProxy)
        {
            _context = context;
            _logger = logger;
            _movieProxy = movieProxy;
        }

        public async Task<DataCollection<PunctuationDTO>> GetAllAsync()
        {
            var collection = await _context.PunctuationsMovies
                .OrderBy(x => x.ID_M)
                .GetPagedAsync();

            return collection.MapTo<DataCollection<PunctuationDTO>>();
        }

        public async Task<PunctuationDTO> GetAsync(int id_m, string email_user)
        {
            return (await _context.PunctuationsMovies.SingleAsync(x => x.ID_M == id_m && x.Email == email_user)).MapTo<PunctuationDTO>();
        }

        public List<string> GetMoreLikeAsync()
        {
            var items = _context.PunctuationsMovies
                .GroupBy(m => m.ID_M)
                .Select(g => new { id = g.Key, total_p = g.Sum(x => x.Points) })
                .OrderByDescending(g => g.total_p)
                .Take(10);

            List<string> movies = new List<string>();

            foreach (var movie in items)
            {
                string name_m = _movieProxy.GetMovieById(movie.id).Result;
                movies.Add(name_m);
            }
            return movies;
        }
    }
}
