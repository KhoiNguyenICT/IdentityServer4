using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Google.Model.Entities
{
    public class Category : BaseEntity
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        public Guid ThumbnailId { get; set; }

        [ForeignKey("ThumbnailId")]
        public virtual Asset Thumbnail { get; set; }

        [Required]
        public Guid AccountId { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account CreatedBy { get; set; }

        public virtual ICollection<Channel> Channels { get; set; }

        [Required]
        public int Order { get; set; }
    }
}