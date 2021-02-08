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
        private readonly ApplicationDbContext _context;
        public VehicleRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Vehicle> GetVehicleByYear(int year)
        {
            return _context.Vehicle
                .Where(vehicle => vehicle.Year == year)
                .Select(model => new Vehicle()
                {
                    Id = model.Id,
                    Year = model.Year,
                    Model = model.Model,
                    Make = model.Make,
                    MSRP = model.MSRP
                });
        }
    }
}
