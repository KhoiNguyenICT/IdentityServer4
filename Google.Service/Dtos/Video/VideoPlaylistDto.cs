using System;
using System.ComponentModel.DataAnnotations;
using Google.Service.Dtos.Playlist;

namespace Google.Service.Dtos.Video
{
    public class VideoPlaylistDto : BaseDto
    {
        [Required]
        public Guid VideoId { get; set; }

        [Required]
        public Guid PlaylistId { get; set; }

        public virtual VideoDto Video { get; set; }

        public virtual PlaylistDto Playlist { get; set; }
    }
}