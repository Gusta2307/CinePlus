﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServicesQueries.DTO
{
    public class UserDTO
    {
        public string UserName { get; set; }

        public string Name_LastName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }

        public bool IsAssociated { get; set; }

        public int Points { get; set; }
    }
}
