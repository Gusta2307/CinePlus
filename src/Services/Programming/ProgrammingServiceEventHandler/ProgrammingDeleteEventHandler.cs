using MediatR;
using ProgrammingDataBase;
using ProgrammingDomain.Models;
using ProgrammingServiceEventHandler.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgrammingServiceEventHandler
{
    public class ProgrammingDeleteEventHandler : INotificationHandler<ProgrammingDeleteCommand>
    {
        private readonly ApplicationDbContext _context;

        public ProgrammingDeleteEventHandler(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task Handle(ProgrammingDeleteCommand notification, CancellationToken cancellationToken)
        {
            var entity = new Programming()
            {
                ID_M = notification.ID_M,
                ID_Cinema = notification.ID_Cinema,
                DataHour_P = notification.DataHour_P
            };
            _context.Programming.Attach(entity);
            _context.Programming.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
