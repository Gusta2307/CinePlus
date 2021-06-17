using Microsoft.EntityFrameworkCore;
using ServiceCommonCollection;
using ServiceCommonMapping;
using ServiceCommonPapping;
using SuggestMovieDataBase;
using SuggestMovieServicesQueries.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuggestMovieServicesQueries
{
    public interface ISuggestMovieQueryService
    {
        Task<DataCollection<SuggestMovieDTO>> GetAllAsync();

        Task<SuggestMovieDTO> GetAsync(string id);

        Task<SuggestMovieDTO> GetSelectedAsync();
    }

    public class SuggestMovieQueryService : ISuggestMovieQueryService
    {
        private readonly ApplicationDbContext _context;

        public SuggestMovieQueryService(ApplicationDbContext context)
        {
            this._context = context;
        }

        //Devuelve una coleccion con todos los posibles tipos de sugerencias
        public async Task<DataCollection<SuggestMovieDTO>> GetAllAsync()
        {
            var collection = await _context.SuggestMovies
                .OrderBy(x => x.Type_S)
                .GetPagedAsync();

            return collection.MapTo<DataCollection<SuggestMovieDTO>>(); //mapea la coleccion del dominio MovieC a MovieDTO
        }

        //Devuelve un tipo de sugerencia
        public async Task<SuggestMovieDTO> GetAsync(string id)
        {
            return (await _context.SuggestMovies.SingleAsync(x => x.Type_S == id)).MapTo<SuggestMovieDTO>();
        }

        //Devuelve el criterio seleccionado por el administrador
        public async Task<SuggestMovieDTO> GetSelectedAsync()
        {
            return (await _context.SuggestMovies.SingleAsync(x => x.Selected == 1)).MapTo<SuggestMovieDTO>();
        }
    }
}
