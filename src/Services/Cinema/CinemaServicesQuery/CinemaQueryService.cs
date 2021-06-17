using CinemaDataBase;
using CinemaServicesQuery.DTO;
using Microsoft.EntityFrameworkCore;
using ServiceCommonCollection;
using ServiceCommonMapping;
using ServiceCommonPapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaServicesQuery
{
    public interface ICinemaQueryService
    {
        Task<DataCollection<CinemaDTO>> GetAllAsync();

        Task<CinemaDTO> GetAsync(int id);
    }

    public class CinemaQueryService : ICinemaQueryService
    {
        private readonly ApplicationDbContext _context;

        public CinemaQueryService(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<DataCollection<CinemaDTO>> GetAllAsync()
        {
            var collection = await _context.Cinemas
                .OrderBy(x => x.ID_Cinema)
                .GetPagedAsync();

            return collection.MapTo<DataCollection<CinemaDTO>>(); //mapea la coleccion del dominio Cinema a CinemaDTO
        }

        public async Task<CinemaDTO> GetAsync(int id)
        {
            return (await _context.Cinemas.SingleAsync(x => x.ID_Cinema == id)).MapTo<CinemaDTO>();
        }
    }
}
