using System;

namespace CarLicenseInfo.Pure.Server.Data
{
    /// <summary>
    /// CarLicenseInfo Entity implementation
    /// </summary>
    public class CarLicenseInfo {
        public int Id { get; set; }

        public string LicensePlate { get; set; }

        public string CityRegion { get; set; }

        public string DerivedFrom { get; set; }

        public string County { get; set; }

    }
    

}