using BaseProject.Models;
using BaseProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProject.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly ILogger<VehicleController> _logger;
        private readonly IBaseRepository<Vehicle> _vehicleService;

        public VehicleController(ILogger<VehicleController> logger, VehicleRepository vehicleService)
        {
            _logger = logger;
            _vehicleService = vehicleService;
        }

        [HttpGet]
        public IEnumerable<VehicleResult> Get()
        {
            var vehicleList = new List<VehicleResult>();
            var queriedList = _vehicleService.Queryable().Where(vehicle => vehicle.Year > 2000);
            var sampleVehicle = new VehicleResult()
            {
                Make = "Audi",
                Model = "A3",
                Year = 2019,
                Price = 23789.98M

            };

            vehicleList.Add(sampleVehicle);
            return vehicleList.AsEnumerable();

        }
    }
}
