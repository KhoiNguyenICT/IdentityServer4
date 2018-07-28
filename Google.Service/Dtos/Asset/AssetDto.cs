using System.ComponentModel.DataAnnotations;
using Google.Common.Enums;

namespace Google.Service.Dtos.Asset
{
    public class AssetDto: BaseDto
    {
        [Required]
        public string AssetsPrimaryName { get; set; }

        [Required]
        public string AssetName { get; set; }

        [Required]
        public string AddressFile { get; set; }

        [Required]
        public double FileSize { get; set; }

        [Required]
        public FileType FileType { get; set; }
    }
}