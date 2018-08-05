using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Google.Model.Entities
{
    public class Channel : BaseEntity
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Guid? ThumbnailId { get; set; }

        public Guid? AvatarId { get; set; }

        public string Description { get; set; }
        public string EmailContact { get; set; }
        public string[] HyperLinks { get; set; }

        [Required]
        public Guid CreateById { get; set; }

        public Guid? OwnerId { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        [ForeignKey("ThumbnailId")]
        public virtual Asset Thumbnail { get; set; }

        [ForeignKey("AvatarId")]
        public virtual Asset Avatar { get; set; }

        [ForeignKey("CreateById")]
        public virtual Account CreatedBy { get; set; }

        [ForeignKey("OwnerId")]
        public virtual Account Owner { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public virtual ICollection<Playlist> Playlists { get; set; }

        public virtual ICollection<Video> Videos { get; set; }
    }
}