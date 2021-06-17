using Microsoft.EntityFrameworkCore;
using ProgrammingDataBase;
using ProgrammingServicesQueries.DTO;
using ProgrammingServiceProxies.Movie;
using ServiceCommonCollection;
using ServiceCommonMapping;
using ServiceCommonPapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace ProgrammingServicesQueries
{
    public interface IProgrammingQueryService
    {
        Task<DataCollection<ProgrammingDTO>> GetAllAsync();

        Task<ProgrammingDTO> GetAsync(int id_m, int id_c, string id_dh);
    }

    public class ProgrammingQueryService : IProgrammingQueryService
    {
        private readonly ApplicationDbContext _context;

        private readonly IMovieProxy _movieProxy;

        private readonly ILogger<ProgrammingQueryService> _logger;

        public ProgrammingQueryService(ApplicationDbContext context, ILogger<ProgrammingQueryService> logger, IMovieProxy movieProxy)
        {
            _context = context;
            _logger = logger;
            _movieProxy = movieProxy;
        }

        //Muestra la cartelera actual
        public async Task<DataCollection<ProgrammingDTO>> GetAllAsync()
        {
            var collection = await _context.Programming
                .OrderBy(x => x.ID_Cinema)
                .GetPagedAsync();

            DataCollection<ProgrammingDTO> new_collection = new DataCollection<ProgrammingDTO>();
            List<ProgrammingDTO> prog = new List<ProgrammingDTO>();

            foreach (var item in collection.Items)
            {
                string name_m = _movieProxy.GetMovieNameById(item.ID_M).Result;
                prog.Add(
                    new ProgrammingDTO
                    {
                        ID_Cinema = item.ID_Cinema,
                        DataHour_P = item.DataHour_P,
                        Name_M = name_m,
                        ID_M = item.ID_M,
                        Ticket_Price = item.Ticket_Price,
                        Pay_Points = item.Pay_Points
                    });
            }
            new_collection.Items = prog;
            return new_collection;
        }

        //Devuelve una fila de la tabla
        public async Task<ProgrammingDTO> GetAsync(int id_m, int id_c, string id_dh)
        {
            return (await _context.Programming.SingleAsync(x => x.ID_M == id_m && x.ID_Cinema == id_c && x.DataHour_P == id_dh)).MapTo<ProgrammingDTO>();
        }
    }
}
