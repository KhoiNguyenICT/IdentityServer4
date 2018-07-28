using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Google.Common.Enums;

namespace Google.Model.Entities
{
    [Table("Assets")]
    public class Asset: BaseEntity
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