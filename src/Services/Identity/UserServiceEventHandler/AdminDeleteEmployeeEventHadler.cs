using IdentityDomain;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UserServiceEventHandler.Command;

namespace UserServiceEventHandler
{
    public class AdminDeleteEmployeeEventHadler : IRequestHandler<AdminDeleteEmployeeCommand, IdentityResult>
    {
        private readonly UserManager<User> _userManager;

        public AdminDeleteEmployeeEventHadler(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> Handle(AdminDeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var item = _userManager.FindByEmailAsync(request.Email).Result;

            var entity = new User()
            {
                UserName = item.Email,
                Name_LastName = item.Name_LastName,
                Password = item.Password,
                Email = item.Email,
                Role = item.Role,
                Points = item.Points
            };

            return await _userManager.DeleteAsync(entity);
        }
    }
}
