using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using CarLicenseInfo.Server.Data;

namespace CarLicenseInfo.Server
{
    public class CarLicenseInfoService : CarLicenseInfo.CarLicenseInfoBase
    {
        private readonly ILogger<CarLicenseInfoService> _logger;
        
        public CarLicenseInfoService(ILogger<CarLicenseInfoService> logger)
        {
            _logger = logger;
        }

        public override Task<CarLicenseInfoResponse> GetCarLicenseInfoInfo(CarLicenseInfoRequest request, ServerCallContext context)
        {
            return Task.FromResult(new CarLicenseInfoResponse
            {
                LicensePlate = "KN",
                CityRegion = "Landkreis Konstanz",
                DerivedFrom = "KoNstanz",
                County = "Baden-Württemberg"
            });
        }
    }
}
