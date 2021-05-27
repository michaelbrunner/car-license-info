using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using CarLicenseInfo.Pure.Server.Data;
using CarLicenseInfo.Pure.Shared;


namespace CarLicenseInfo.Pure.Server.Services
{
    /// <summary>
    /// Implements the CarLicenseInfo Proto API.
    /// </summary>
    public class CarLicenseInfoService : CarLicenseInfoGrpc.CarLicenseInfoGrpcBase
    { 
        private readonly ILogger<CarLicenseInfoService> _logger;
        private readonly ApplicationDbContext _dbContext;
        
        public CarLicenseInfoService(ILogger<CarLicenseInfoService> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        /// <summary>
        /// Queries the database for the given license plate.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<CarLicenseInfoResponse> GetCarLicenseInfo(CarLicenseInfoRequest request, ServerCallContext context) 
        {
            var carLicenseInfoData = _dbContext.CarLicenseInfo.SingleOrDefault(x => x.LicensePlate == request.LicensePlate);

            if (carLicenseInfoData == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, "No car license found"));
            }
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
