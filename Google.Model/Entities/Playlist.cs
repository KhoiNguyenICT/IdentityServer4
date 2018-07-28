using Google.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Google.Model.Entities
{
    public class Playlist : BaseEntity
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }
        public Guid ThumbnailId { get; set; }
        public PlayListStatusType PlayListStatusType { get; set; }

        [ForeignKey("ThumbnailId")]
        public virtual Asset Thumbnail { get; set; }

        [Required]
        public Guid AccountId { get; set; }

        [ForeignKey("AccountId")]
        public Account CreatedBy { get; set; }
    }
}