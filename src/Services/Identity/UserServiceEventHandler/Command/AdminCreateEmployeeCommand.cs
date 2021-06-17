using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserServiceEventHandler.Command
{
    public class AdminCreateEmployeeCommand : IRequest<IdentityResult>
    {
        [Required]
        public string Name_LastName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Confirm_Password { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        public string Employee_Type { get; set; }

    }
}
