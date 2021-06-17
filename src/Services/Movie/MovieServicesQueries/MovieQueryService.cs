using Microsoft.EntityFrameworkCore;
using MovieDataBase;
using MovieServicesQueries.DTO;
using ServiceCommonCollection;
using ServiceCommonMapping;
using ServiceCommonPapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieServicesQueries
{
    public interface IMovieQueryService
    {
        Task<DataCollection<MovieDTO>> GetAllAsync();

        Task<MovieDTO> GetAsync(int id);       

        Task<DataCollection<MovieDTO>> GetMoreLikeAsync();

        string GetName(int id);
    }
    public class MovieQueryService : IMovieQueryService
    {
        private readonly ApplicationDbContext _context;

        public MovieQueryService(ApplicationDbContext context)
        {
            this._context = context;
        }

        //Devuelve una coleccion con todas las peliculas de la bd
        public async Task<DataCollection<MovieDTO>> GetAllAsync()
        {
            var collection = await _context.Movies
                .OrderBy(x => x.ID_M)
                .GetPagedAsync();

            return collection.MapTo<DataCollection<MovieDTO>>(); //mapea la coleccion del dominio MovieC a MovieDTO
        }

        //Devuelve una pelicula especifica
        public async Task<MovieDTO> GetAsync(int id)
        {
            return (await _context.Movies.SingleAsync(x => x.ID_M == id)).MapTo<MovieDTO>();
        }

        //poner en puntuacion pelicula
        public Task<DataCollection<MovieDTO>> GetMoreLikeAsync()
        {
            throw new NotImplementedException();
        }

        public string GetName(int id)
        {
            var nameMovie = GetAsync(id).Result.Name_P;
            return nameMovie;
        }
    }
}
