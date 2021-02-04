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
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
