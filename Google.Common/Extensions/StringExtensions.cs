using Google.Common.Constants;
using Microsoft.Extensions.Configuration;
using System;

namespace Google.Common.Extensions
{
    public static class StringExtensions
    {
        public static string GenerateAssetName(string fileName)
        {
            return Guid.NewGuid().ToString() + "." + fileName.Split('.')[fileName.Split('.').Length - 1];
        }

        public static string GenerateAddressAssetName(string fileName)
        {
            var address = ConfigurationKeys.UploadFolder + Guid.NewGuid().ToString() + "." + fileName.Split('.')[fileName.Split('.').Length - 1];
            return address;
        }
    }
}