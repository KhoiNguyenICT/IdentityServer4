using Google.Common.Enums;
using Google.Service.Dtos.Account;
using Google.Service.Dtos.Playlist;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Google.Service.Dtos.Channel;

namespace Google.Service.Dtos.Video
{
    public class VideoDto : BaseDto
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

        public virtual ChannelDto Channel { get; set; }

        public virtual ICollection<PlaylistDto> Playlists { get; set; }

        [Required]
        public Guid AccountId { get; set; }

        public virtual AccountDto CreatedBy { get; set; }
    }
}