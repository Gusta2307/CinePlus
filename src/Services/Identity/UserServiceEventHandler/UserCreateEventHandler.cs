using IdentityDomain;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UserServiceEventHandler.Command;

namespace UserServiceEventHandler
{
    public class UserCreateEventHandler : IRequestHandler<UserCreateCommand, IdentityResult>
    {
        private readonly UserManager<User> _userManager;

        public UserCreateEventHandler(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> Handle(UserCreateCommand request, CancellationToken cancellationToken)
        {
            var entry = new User
            {
                UserName = request.Email,
                Name_LastName = request.Name_LastName,
                Password = request.Password,
                Email = request.Email,
                Role = request.IsAssociated ? "Asociado" : "Cliente",
                Points = request.Points,
            };

            return await _userManager.CreateAsync(entry, request.Password);
        }
    }
}
