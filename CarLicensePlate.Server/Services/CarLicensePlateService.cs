using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using CarLicensePlate.Server.Data;

namespace CarLicensePlate.Server
{
    public class CarLicensePlateService : CarLicensePlate.CarLicensePlateBase
    {
        private readonly ILogger<CarLicensePlateService> _logger;
        
        public CarLicensePlateService(ILogger<CarLicensePlateService> logger)
        {
            _logger = logger;
        }

        public override Task<CarLicensePlateResponse> GetCarLicensePlateInfo(CarLicensePlateRequest request, ServerCallContext context)
        {
            return Task.FromResult(new CarLicensePlateResponse
            {
                LicensePlate = "KN",
                CityRegion = "Landkreis Konstanz",
                DerivedFrom = "KoNstanz",
                County = "Baden-Württemberg"
            });
        }
    }
}
