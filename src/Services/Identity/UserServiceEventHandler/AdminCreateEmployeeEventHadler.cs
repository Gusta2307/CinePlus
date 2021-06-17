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
    public class AdminCreateEmployeeEventHadler : IRequestHandler<AdminCreateEmployeeCommand, IdentityResult>
    {
        private readonly UserManager<User> _userManager;

        public AdminCreateEmployeeEventHadler(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> Handle(AdminCreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var entry = new User
            {
                UserName = request.Email,
                Name_LastName = request.Name_LastName,
                Password = request.Password,
                Email = request.Email,
                Role = request.Employee_Type,
            };

            return await _userManager.CreateAsync(entry, request.Password);
        }
    }
}
