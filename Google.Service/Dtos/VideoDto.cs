using Google.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Google.Service.Dtos
{
    public class VideoDto
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
        public virtual ICollection<PlaylistDto> Playlists { get; set; }

        public Guid AccountId { get; set; }

        public virtual AccountDto CreatedBy { get; set; }
    }
}