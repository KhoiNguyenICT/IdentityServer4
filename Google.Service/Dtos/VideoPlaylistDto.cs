using System;
using System.ComponentModel.DataAnnotations;

namespace Google.Service.Dtos
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