using Google.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Google.Model.Entities
{
    public class Video : BaseEntity
    {
        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public int ViewCount { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }
        public TimeSpan VideoDuration { get; set; }
        public VideoStatusType VideoStatusType { get; set; }

        [Required]
        public Guid ChannelId { get; set; }

        [ForeignKey("ChannelId")]
        public virtual Channel Channel { get; set; }

        public virtual ICollection<Playlist> Playlists { get; set; }

        [Required]
        public Guid AccountId { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account CreatedBy { get; set; }
    }
}