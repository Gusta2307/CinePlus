using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ArmchairDataBase;
using ArmchairDomain;
using ArmchairServiceEventHandler.Command;
using ArmchairServiceEventHandler.Reponse;
using ArmchairServicesQueries;
using MediatR;
using ServiceCommonPapping;

namespace ArmchairServiceEventHandler
{
    public class ArmchairUpdateReservedEventHandler : IRequestHandler<ArmchairUpdateReservedCommand, UpdateReponse>
    {
        private readonly ApplicationDbContext _context;

        private readonly IArmchairQueryService _cinemaQueryService;

        public ArmchairUpdateReservedEventHandler(ApplicationDbContext context, IArmchairQueryService progQueryService)
        {
            _context = context;
            _cinemaQueryService = progQueryService;
        }

        public async Task<UpdateReponse> Handle(ArmchairUpdateReservedCommand request, CancellationToken cancellationToken)
        {
            var result = new UpdateReponse();

            var collection = _context.Armchairs
                .Where(x => x.ID_Cinema == request.ID_Cinema && request.Num_ArmchairsIEnu.Contains(x.Num_Armchair));

            foreach (var elemt in collection)
            {
                var item = _context.Armchairs.Find(request.ID_Cinema, elemt.Num_Armchair);
                _context.Armchairs.Remove(item);

                await _context.AddAsync(new Armchair()
                {
                    ID_Cinema = request.ID_Cinema,
                    Num_Armchair = elemt.Num_Armchair,
                    Reserved = "SI"
                });
            }

            await _context.SaveChangesAsync();

            string buy_code = Generate_Cod();
            result.Succeeded = true;
            result.Buy_Cod = buy_code;
            return result;
        }

        public string Generate_Cod()
        {
            string codB = "CODBBB";
            return codB;
        }
    }
}
