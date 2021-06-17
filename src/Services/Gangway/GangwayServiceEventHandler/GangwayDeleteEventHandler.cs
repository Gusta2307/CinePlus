using GangawayDataBase;
using GangwayDomain;
using GangwayProxie.Booking;
using GangwayServiceEventHandler.Command;
using GangwayServiceEventHandler.Reponse;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GangwayServiceEventHandler
{
    public class GangwayDeleteEventHandler : IRequestHandler<GangwayDeleteCommand, GangwayResult>
    {
        private readonly ApplicationDbContext _context;

        private readonly IBookingProxy _bookingProxy;

        public GangwayDeleteEventHandler(ApplicationDbContext context, IBookingProxy bookingProxy)
        {
            _context = context;
            _bookingProxy = bookingProxy;
        }

        public async Task<GangwayResult> Handle(GangwayDeleteCommand request, CancellationToken cancellationToken)
        {
            var entity = new UserPay()
            {
                Email = request.Email,
                Credit_Card = request.Credit_Card
            };
            _context.Pays.Attach(entity);
            _context.Pays.Remove(entity);

            float total_money = float.Parse(_bookingProxy.GetTotalMoneyById(request.Buy_Cod).Result);
            await _context.SaveChangesAsync();

            return new GangwayResult
            {
                Total_Money = total_money
            };
        }
    }
}
