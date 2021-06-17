using IdentityDataBase;
using IdentityServicesQueries.DTO;
using Microsoft.EntityFrameworkCore;
using ServiceCommonCollection;
using ServiceCommonMapping;
using ServiceCommonPapping;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServicesQueries
{
    public interface IUserQueryService
    {
        Task<DataCollection<UserDTO>> GetAllAsync();
        
        Task<UserDTO> GetAsync(string id);

        bool IsAssociated(string email_user);
    }

    public class UserQueryService : IUserQueryService
    {
        private readonly ApplicationDbContext _context;

        public UserQueryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DataCollection<UserDTO>> GetAllAsync()
        {
            var collection = await _context.Users
                .GetPagedAsync();

            return collection.MapTo<DataCollection<UserDTO>>();
        }

        public async Task<UserDTO> GetAsync(string id)
        {
            return (await _context.Users.SingleAsync(x => x.Id == id)).MapTo<UserDTO>();
        }

        public bool IsAssociated(string email_user)
        {
            var user = _context.Users.Find(email_user);
            return user.Role == "Asociado";
        }
    }
}