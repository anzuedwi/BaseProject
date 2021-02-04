using BaseProject.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProject.Models
{
    public class ApplicationUser : IdentityUser, IEntity
    {
    }
}
