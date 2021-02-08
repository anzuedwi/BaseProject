using BaseProject.Data;
using BaseProject.Models;
using IdentityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProject.Services
{
    public class UserRepository : BaseRepository<ApplicationUser, ApplicationDbContext>
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<ApplicationUser> GetUserByEmail(string email)
        {
            var user = _context.Users
                .Where(user => user.Email.Equals(email, StringComparison.InvariantCultureIgnoreCase))
                .SingleOrDefault();
            return user;
        }
    }
}
