using ArmchairDataBase;
using ArmchairServicesQueries.DTO;
using Microsoft.EntityFrameworkCore;
using ServiceCommonCollection;
using ServiceCommonMapping;
using ServiceCommonPapping;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ArmchairServicesQueries
{
    public interface IArmchairQueryService
    {
        Task<DataCollection<ArmchairDTO>> GetAllArmchairAsync(int id_c);

        Task<DataCollection<ArmchairDTO>> AsignArmchairsAsync(int id_c, int count_tickets);

        Task<ArmchairDTO> GetAsync(int id_c, int id_a);
    }

    public class ArmchairQueryService : IArmchairQueryService
    {
        private readonly ApplicationDbContext _context;

        public ArmchairQueryService(ApplicationDbContext context)
        {
            this._context = context;
        }

        //Asigna <count_tickets> butacas disponibles en la sala id_c
        public async Task<DataCollection<ArmchairDTO>> AsignArmchairsAsync(int id_c, int count_tickets)
        {
            var collection = await _context.Armchairs
                .Where(x => x.ID_Cinema == id_c && x.Reserved == "NO")
                .Take(count_tickets)
                .OrderBy(x => x.ID_Cinema)
                .GetPagedAsync();

            return collection.MapTo<DataCollection<ArmchairDTO>>();
        }

        //Muestra las butacas y su respectiva sala
        public async Task<DataCollection<ArmchairDTO>> GetAllArmchairAsync(int id_c)
        {
            var collection = await _context.Armchairs
                .Where(x => x.ID_Cinema == id_c && x.Reserved == "NO")
                .OrderBy(x => x.Num_Armchair)
                .GetPagedAsync();

            return collection.MapTo<DataCollection<ArmchairDTO>>(); //mapea la coleccion del dominio Armchair a ArmchairDTO
        }

        public async Task<ArmchairDTO> GetAsync(int id_c, int id_a)
        {
            return (await _context.Armchairs.SingleAsync(x => (x.ID_Cinema == id_c && x.Num_Armchair == id_a))).MapTo<ArmchairDTO>();
        }
    }
}
