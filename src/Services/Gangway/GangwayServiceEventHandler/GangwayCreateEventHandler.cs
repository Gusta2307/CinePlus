using GangawayDataBase;
using GangwayDomain;
using GangwayServiceEventHandler.Command;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GangwayServiceEventHandler
{
    public class GangwayCreateEventHandler : INotificationHandler<GangwayCreateCommand>
    {
        private readonly ApplicationDbContext _context;

        public GangwayCreateEventHandler(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task Handle(GangwayCreateCommand notification, CancellationToken cancellationToken)
        {
            await _context.AddAsync(new UserPay
            {
                Email = notification.Email,
                Credit_Card = notification.Credit_Card
            });

            await _context.SaveChangesAsync();
        }
    }
}
