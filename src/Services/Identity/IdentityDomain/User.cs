using Microsoft.AspNetCore.Identity;

namespace IdentityDomain
{
    public class User : IdentityUser
    {
        public string Name_LastName { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public int Points { get; set; }

        public bool IsAssociated { get; set; }
    }
}
