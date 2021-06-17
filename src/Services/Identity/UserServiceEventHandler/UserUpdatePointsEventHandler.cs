using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using UserServiceEventHandler.Command;
using IdentityDataBase;
using IdentityServicesQueries;
using System.Threading;
using IdentityDomain;

namespace UserServiceEventHandler
{
    public class UserUpdatePointsEventHandler : INotificationHandler<UserUpdatePointsCommand>
    {
        private readonly ApplicationDbContext _context;

        private readonly IUserQueryService _userQueryService;

        public UserUpdatePointsEventHandler(ApplicationDbContext context, IUserQueryService userQueryService)
        {
            _context = context;
            _userQueryService = userQueryService;
        }

        //Actualizar la cantidad de puntos
        public async Task Handle(UserUpdatePointsCommand notification, CancellationToken cancellationToken)
        {
            int new_poinst;
            var item = _context.Users.Find(notification.Email_User);

            if (notification.Operation == Command.Action.Sum)
                new_poinst = item.Points + notification.Count_Poinst;
            else new_poinst = item.Points - notification.Count_Poinst;

            _context.Users.Remove(item);

            await _context.AddAsync(new User()
            {
                Id = item.Id,
                Name_LastName = item.Name_LastName,
                Email = item.Email,
                Password = item.Password,
                Role = item.Role,
                Points = new_poinst
            });

            await _context.SaveChangesAsync();
        }
    }
}
