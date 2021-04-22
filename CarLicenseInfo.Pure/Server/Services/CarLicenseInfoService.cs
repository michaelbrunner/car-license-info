using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using CarLicenseInfo.Pure.Shared;
using CarLicenseInfo.Pure.Server.Data;

namespace CarLicenseInfo.Pure.Server.Services
{
    public class CarLicenseInfoService : CarLicenseInfo.Pure.Shared.CarLicenseInfo.CarLicenseInfoBase
    {
        private readonly ILogger<CarLicenseInfoService> _logger;
        private readonly ApplicationDbContext _dbContext;
        
        public CarLicenseInfoService(ILogger<CarLicenseInfoService> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public override Task<CarLicenseInfoResponse> GetCarLicenseInfo(CarLicenseInfoRequest request, ServerCallContext context)
        {
            var carLicenseInfoData = _dbContext.CarLicenseInfo.SingleOrDefault(x => x.LicensePlate == request.LicensePlate);

            return Task.FromResult<CarLicenseInfoResponse>(new CarLicenseInfoResponse 
            {
                LicensePlate = carLicenseInfoData?.LicensePlate,
                CityRegion = carLicenseInfoData?.CityRegion,
                DerivedFrom = carLicenseInfoData?.DerivedFrom,
                County = carLicenseInfoData?.County               
            });
        }
    }
}