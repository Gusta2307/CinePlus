using EstadisticDataBase;
using EstadisticServicesQueries.DTO;
using Microsoft.EntityFrameworkCore;
using ServiceCommonCollection;
using ServiceCommonMapping;
using ServiceCommonPapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstadisticServicesQueries
{
    public interface IEstadisticQueryService
    {
        Task<DataCollection<EstadisticDTO>> GetAllAsync();

        Task<EstadisticDTO> GetAsync(int id);
    }

    public class EstadisticQueryService : IEstadisticQueryService
    {
        private readonly ApplicationDbContext _context;

        public EstadisticQueryService(ApplicationDbContext context)
        {
            _context = context;
        }

        //Devuelve todos los posibles criterios de estadisticas de la bd
        public async Task<DataCollection<EstadisticDTO>> GetAllAsync()
        {
            var collection = await _context.Estadistics
                .OrderBy(x => x.ID_E)
                .GetPagedAsync();

            return collection.MapTo<DataCollection<EstadisticDTO>>(); //mapea la coleccion del dominio Cinema a CinemaDTO
        }

        public async Task<EstadisticDTO> GetAsync(int id)
        {
            return (await _context.Estadistics.SingleAsync(x => x.ID_E == id)).MapTo<EstadisticDTO>();
        }
    }
}
