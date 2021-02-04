using BaseProject.Data;
using BaseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProject.Services
{
    public class VehicleRepository : BaseRepository<Vehicle, ApplicationDbContext>
    {
        public VehicleRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
